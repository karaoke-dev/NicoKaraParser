using Microsoft.VisualStudio.TestTools.UnitTesting;
using NicoKaraParser.Model;
using System.IO;

namespace NicoKaraParser.Tests
{
    public class BaseUnitTest
    {
        protected virtual string ResourseFilePath => "SamleProject/project.nkmproj";

        protected Parser Parser;

        [TestInitialize]
        public void TestInitialize()
        {
            Parser = new Parser();
        }

        protected virtual Project DecodeWithFile()
        {
            var path = "Resources/" + ResourseFilePath;
            var fileExist = File.Exists(path);
            if (!fileExist)
                return null;

            using (var sr = new StreamReader(path))
            {
                return Parser.Deserialize(sr) as Project;
            }
        }
    }
}
