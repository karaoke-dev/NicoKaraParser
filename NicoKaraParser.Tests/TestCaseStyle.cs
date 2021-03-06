﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NicoKaraParser.Model;
using System.Linq;
using NicoKaraParser.Model.Style;

namespace NicoKaraParser.Tests
{
    [TestClass]
    public class TestCaseStyle : BaseUnitTest
    {
        [TestMethod]
        public void CheckStyle()
        {
            var result = DecodeWithFile();
            var styles = result.KaraokeStyles;
            var firstStyle = styles.FirstOrDefault();

            // Check has at least one font
            Assert.IsNotNull(firstStyle);

            // Type
            Assert.AreEqual(firstStyle.Kind, KaraokeStyleKind.Lyrics);

            // Start time and end time
            Assert.AreEqual(firstStyle.ShowBeginTime, 600);
            Assert.AreEqual(firstStyle.ShowEndTime, 11240);

            // Font and style style index
            Assert.AreEqual(firstStyle.KaraokeFontIndex, 0);
            Assert.AreEqual(firstStyle.KaraokeLayoutIndex, 1);

            // Part and rubies
            Assert.IsTrue(firstStyle.LyricsParts.Any());
            Assert.IsTrue(firstStyle.ApplyRubies.Any());

            // Lyric and it's position in file
            Assert.AreEqual(firstStyle.PlainText, "…上座の上にある　上着を、");
            Assert.AreEqual(firstStyle.LineIndexInFile, 0);
        }

        [TestMethod]
        public void CheckStyleLyric()
        {
            // TODO : implement
        }

        [TestMethod]
        public void CheckStyleRuby()
        {
            // TODO : implement
        }
    }
}
