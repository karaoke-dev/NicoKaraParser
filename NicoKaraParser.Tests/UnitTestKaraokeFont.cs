using Microsoft.VisualStudio.TestTools.UnitTesting;
using NicoKaraParser.Model;
using System.Linq;

namespace NicoKaraParser.Tests
{
    [TestClass]
    public class UnitTestKaraokeFont : BaseUnitTest
    {
        [TestMethod]
        public void CheckKaraokeFont()
        {
            var result = DecodeWithFile();
            var fonts = result.KaraokeFonts.KaraokeFont;
            var firstFont = fonts.FirstOrDefault();

            // Check has at least one font
            Assert.IsNotNull(firstFont);

            // Has name
            Assert.AreEqual(firstFont.Name, "標準配色");

            // Brush info should be 6
            Assert.AreEqual(firstFont.BrushInfos.BrushInfo.Count(), 6);

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
            Assert.AreEqual(brushInfos[1].Type, BrushType.Gradient);
            Assert.AreEqual(brushInfos[2].Type, BrushType.Solid);

            // Now testing first brush info
            var firstBrushInfo = brushInfos[0];
            var positionCount = firstBrushInfo.GradientPositions.Float.Count();
            var colorCount = firstBrushInfo.GradientColorsSave.Int.Count();

            // Position and color should be equal or greater then 2
            Assert.IsTrue(positionCount >= 2);
            Assert.IsTrue(colorCount >= 2);
            Assert.AreEqual(positionCount, colorCount);

            // Brush info should be 6
            Assert.AreEqual(firstBrushInfo.SolidColorSave, -65281);
        }

        [TestMethod]
        public void CheckKaraokeFontFontInfo()
        {
            var result = DecodeWithFile();
            var fonts = result.KaraokeFonts.KaraokeFont;
            var fontInfos = fonts.FirstOrDefault().FontInfos.FontInfo;

            // Check type
            Assert.AreEqual(fontInfos[0].FontName, "游明朝 Demibold");
            Assert.AreEqual(fontInfos[0].FontStyle, FontStyle.Regular);
            Assert.AreEqual(fontInfos[0].CharSize, 40);
            Assert.AreEqual(fontInfos[0].EdgeSize, 10);
        }
    }
}
