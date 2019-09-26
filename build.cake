#tool "nuget:?package=coveralls.io&version=1.4.2"
#addin Cake.Git
#addin nuget:?package=Nuget.Core
#addin "nuget:?package=Cake.Coveralls&version=0.9.0"

using NuGet;


// Define parameter
var target = Argument("target", "Default");
var artifactsDir = "./artifacts/";
var solutionPath = "./NicoKaraParser.sln";
var project = "./NicoKaraParser/NicoKaraParser.csproj";
var testFolder = "./NicoKaraParser.Tests/";
var testProject = testFolder + "NicoKaraParser.Tests.csproj";
var coverageResultsFileName = "coverage.xml";
var currentBranch = Argument<string>("currentBranch", GitBranchCurrent("./").FriendlyName);
var isReleaseBuild = string.Equals(currentBranch, "master", StringComparison.OrdinalIgnoreCase);
var configuration = "Release";
var nugetApiKey = Argument<string>("nugetApiKey", null);
var coverallsToken = Argument<string>("coverallsToken", null);
var nugetSource = "https://api.nuget.org/v3/index.json";

// Clean up
Task("Clean")
    .Does(() => {
        if (DirectoryExists(artifactsDir))
        {
            DeleteDirectory(
                artifactsDir, 
                new DeleteDirectorySettings {
                    Recursive = true,
                    Force = true
                }
            );
        }
        CreateDirectory(artifactsDir);
        DotNetCoreClean(solutionPath);
    });

// Restore
Task("Restore")
    .Does(() => {
        DotNetCoreRestore(solutionPath);
    });

// Build
Task("Build")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
    .Does(() => {
        DotNetCoreBuild(
            solutionPath,
            new DotNetCoreBuildSettings 
            {
                Configuration = configuration
            }
        );
    });

// Test all testcase
Task("Test")
    .Does(() => {
        var settings = new DotNetCoreTestSettings
        {
            ArgumentCustomization = args => args.Append("/p:CollectCoverage=true")
                                                .Append("/p:CoverletOutputFormat=opencover")
                                                //.Append("/p:CoverletOutput=./" + coverageResultsFileName)
        };
        DotNetCoreTest(testProject, settings);
        //MoveFile(testFolder + coverageResultsFileName, artifactsDir + coverageResultsFileName);
    });

// Upload test coverage
Task("UploadCoverage")
    .IsDependentOn("Test")
    .Does(() =>
    {
        CoverallsIo(artifactsDir + coverageResultsFileName, new CoverallsIoSettings()
        {
            RepoToken = coverallsToken
        });
    });

// Package the project
Task("Package")
    .Does(() => {
        var settings = new DotNetCorePackSettings
        {
            OutputDirectory = artifactsDir,
            NoBuild = true
        };
        DotNetCorePack(project, settings);
    });

// Publish nuget package to nuget.org
Task("Publish")
    .IsDependentOn("Package")
    .Does(() => {
        var pushSettings = new DotNetCoreNuGetPushSettings 
        {
            Source = nugetSource,
            ApiKey = nugetApiKey
        };

        var pkgs = GetFiles(artifactsDir + "*.nupkg");
        foreach(var pkg in pkgs) 
        {
            if(!IsNuGetPublished(pkg)) 
            {
                Information($"Publishing \"{pkg}\".");
                DotNetCoreNuGetPush(pkg.FullPath, pushSettings);
            }
            else {
                // If goes to here, maybe means version id is not change.
                Information($"Bypassing publishing \"{pkg}\" as it is already published.");
            }
            
        }
    });

// Check nuget package is published
private bool IsNuGetPublished(FilePath packagePath) {
    var package = new ZipPackage(packagePath.FullPath);

    var latestPublishedVersions = NuGetList(
        package.Id,
        new NuGetListSettings 
        {
            Prerelease = true
        }
    );

    return latestPublishedVersions.Any(p => package.Version.Equals(new SemanticVersion(p.Version)));
}

// Execute build and test action
Task("BuildAndTest")
    .IsDependentOn("Build")
    .IsDependentOn("Test");

// Execute build and test, then upload result
Task("CompleteWithoutPublish")
    .IsDependentOn("Build")
    .IsDependentOn("Test");
    //.IsDependentOn("UploadCoverage");

// if current branch is master, the run release build
if(isReleaseBuild)
{
    Information("Release build");
    Task("Complete")
        .IsDependentOn("Build")
        .IsDependentOn("Test")
        //.IsDependentOn("UploadCoverage")
        .IsDependentOn("Publish");
}
else
{
    Information("Development build");
    Task("Complete")
        .IsDependentOn("Build")
        .IsDependentOn("Test");
        //.IsDependentOn("UploadCoverage");
}

// Defaut action(just compile)
Task("Default")
    .IsDependentOn("Complete");

// Run target
RunTarget(target);