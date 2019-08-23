using Microsoft.VisualStudio.TestTools.UnitTesting;
using NicoKaraParser.Model;
using System.Linq;

namespace NicoKaraParser.Tests
{
    [TestClass]
    public class TestCaseLayout : BaseUnitTest
    {
        [TestMethod]
        public void CheckLayout()
        {
            var result = DecodeWithFile();
            var firstLayout = result.KaraokeLayouts.KaraokeLayout.FirstOrDefault();

            // Check has at least one font
            Assert.IsNotNull(firstLayout);

            // Has name
            Assert.AreEqual(firstLayout.Name, "下-1");

            // Continuous
            Assert.AreEqual(firstLayout.Continuous, false);

            // Horizontal
            Assert.AreEqual(firstLayout.HorizontalAlignment, HorizontalAlignment.Right);
            Assert.AreEqual(firstLayout.HorizontalMargin, 30);
            Assert.AreEqual(firstLayout.SmartHorizon, SmartHorizon.Single);

            // Vertical
            Assert.AreEqual(firstLayout.VerticalAlignment, VerticalAlignment.Bottom);
            Assert.AreEqual(firstLayout.VerticalMargin, 45);

            // Lyric
            Assert.AreEqual(firstLayout.LyricsInterval, 4);

            // Ruby
            Assert.AreEqual(firstLayout.RubyInterval, 2);
            Assert.AreEqual(firstLayout.RubyAlignment, RubyAlignment.EqualSpace);
            Assert.AreEqual(firstLayout.RubyMargin, 4);
        }
    }
}
