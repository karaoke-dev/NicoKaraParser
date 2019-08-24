using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace NicoKaraParser.Tests
{
    [TestClass]
    public class TestCaseTitle : BaseUnitTest
    {
        [TestMethod]
        public void TestTitle()
        {
            var result = DecodeWithFile();
            var firstTitle = result.TitleInfos.FirstOrDefault();

            // Check has at least one font
            Assert.IsNotNull(firstTitle);

            // Has name
            Assert.AreEqual(firstTitle.Name, "常設左");

            //Some property
            Assert.AreEqual(firstTitle.KaraokeLayoutIndex, 10);
            Assert.AreEqual(firstTitle.BeginTime, 0);
            Assert.AreEqual(firstTitle.EndTime, 5999990);
            Assert.AreEqual(firstTitle.LineInterval, 10);
            Assert.AreEqual(firstTitle.ShowRuby, false);

            // Title style
            var fiestTitleStyle = firstTitle.TitleStyles.FirstOrDefault();

            // Check first title style
            Assert.AreEqual(fiestTitleStyle.Title, "@Title / @Artist");
            Assert.AreEqual(fiestTitleStyle.KaraokeFontIndex, 8);
            Assert.AreEqual(fiestTitleStyle.Continuous, false);
        }
    }
}
