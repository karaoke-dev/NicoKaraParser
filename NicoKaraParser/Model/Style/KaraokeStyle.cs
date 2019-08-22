using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "KaraokeStyle")]
    public class KaraokeStyle
    {
        [XmlElement(ElementName = "Kind")]
        public string Kind { get; set; }
        [XmlElement(ElementName = "ShowBeginTime")]
        public string ShowBeginTime { get; set; }
        [XmlElement(ElementName = "ShowEndTime")]
        public string ShowEndTime { get; set; }
        [XmlElement(ElementName = "LyricsParts")]
        public LyricsParts LyricsParts { get; set; }
        [XmlElement(ElementName = "ApplyRubies")]
        public ApplyRubies ApplyRubies { get; set; }
        [XmlElement(ElementName = "KaraokeFontIndex")]
        public string KaraokeFontIndex { get; set; }
        [XmlElement(ElementName = "KaraokeLayoutIndex")]
        public string KaraokeLayoutIndex { get; set; }
        [XmlElement(ElementName = "PlainText")]
        public string PlainText { get; set; }
        [XmlElement(ElementName = "LineIndexInFile")]
        public string LineIndexInFile { get; set; }
    }
}
