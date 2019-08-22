using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "LyricsPart")]
    public class LyricsPart
    {
        [XmlElement(ElementName = "BeginTime")]
        public string BeginTime { get; set; }
        [XmlElement(ElementName = "EndTime")]
        public string EndTime { get; set; }
        [XmlElement(ElementName = "Lyrics")]
        public string Lyrics { get; set; }
    }
}
