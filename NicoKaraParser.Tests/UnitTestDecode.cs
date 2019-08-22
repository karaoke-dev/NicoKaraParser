using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NicoKaraParser.Model;

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
        public void CheckKaraokeFont()
        {
            var result = DecodeWithFile();
            var fonts = result.KaraokeFonts.KaraokeFont;
            var firstFont = fonts.FirstOrDefault();

            // Check has at least one font
            Assert.IsNotNull(firstFont);

            // Has name
            Assert.AreEqual(firstFont.Name, "•W€”zF");

            // Brush info should be 6
            Assert.AreEqual(firstFont.BrushInfos.BrushInfo.Count(),6);

            // Font info should be 6
            Assert.AreEqual(firstFont.FontInfos.FontInfo.Count(), 6);

            // Shadow
            Assert.AreEqual(firstFont.UseShadow, true);
            Assert.AreEqual(firstFont.ShadowSlide.X, 3);
            Assert.AreEqual(firstFont.ShadowSlide.Y, 3);
        }

        [TestMethod]
        public void CheckKaraokeFontBrushInfo()
        {
            var result = DecodeWithFile();
            var fonts = result.KaraokeFonts.KaraokeFont;
            var brushInfos = fonts.FirstOrDefault().BrushInfos.BrushInfo;

            // Check type
            Assert.AreEqual(brushInfos[0].Type, BrushType.Solid);
            Assert.AreEqual(brushInfos[1].Type, BrushType.Solid);
            Assert.AreEqual(brushInfos[2].Type, BrushType.Solid);

            // Now testing first brush info
            var firstBrushInfo = brushInfos[0];
            var positionCount = firstBrushInfo.GradientPositions.Float.Count();
            var colorCount = firstBrushInfo.GradientColorsSave.Int.Count();

            // Position and color should be equal or greater then 2
            Assert.IsTrue(positionCount >= 2);
            Assert.IsTrue(colorCount >= 2);
            Assert.AreEqual(positionCount,colorCount);

            // Brush info should be 6
            Assert.AreEqual(firstBrushInfo.SolidColorSave, -65281);
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
