using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "KaraokeStyle")]
    public class KaraokeStyle
    {
        [XmlElement(ElementName = "Kind")]
        public KaraokeStyleKind Kind { get; set; }

        [XmlElement(ElementName = "ShowBeginTime")]
        public int ShowBeginTime { get; set; }

        [XmlElement(ElementName = "ShowEndTime")]
        public int ShowEndTime { get; set; }

        [XmlElement(ElementName = "LyricsParts")]
        public LyricsParts LyricsParts { get; set; }

        [XmlElement(ElementName = "ApplyRubies")]
        public ApplyRubies ApplyRubies { get; set; }

        [XmlElement(ElementName = "KaraokeFontIndex")]
        public int KaraokeFontIndex { get; set; }

        [XmlElement(ElementName = "KaraokeLayoutIndex")]
        public int KaraokeLayoutIndex { get; set; }

        [XmlElement(ElementName = "PlainText")]
        public string PlainText { get; set; }

        [XmlElement(ElementName = "LineIndexInFile")]
        public int LineIndexInFile { get; set; }
    }
}
