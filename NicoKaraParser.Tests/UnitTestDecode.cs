using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NicoKaraParser.Tests
{
    [TestClass]
    public class UnitTestDecode : BaseUnitTest
    {
        [TestMethod]
        public void CheckProjectProperty()
        {
            var result = DecodeWithFile();

            // Check result
            Assert.AreEqual(result.AppVer, "Ver 7.86");
            Assert.AreEqual(result.IsDefaultStyleNeeded, false);

            // Lyric path is not null
            Assert.IsNotNull(result.LyricsPath);
            Assert.IsNotNull(result.LyricsRelativePath);

            // Export format
            Assert.AreEqual(result.DestFormat, "UnCompressedAvi");
            Assert.AreEqual(result.DoubleFrame, false);

            // Not really importent property
            Assert.IsNotNull(result.Xsi);
            Assert.IsNotNull(result.Xsd);
        }

        

        [TestMethod]
        public void CheckKaraokeLayout()
        {

        }

        [TestMethod]
        public void CheckKaraokeStyle()
        {

        }

        [TestMethod]
        public void CheckTitleInfo()
        {

        }
    }
}
