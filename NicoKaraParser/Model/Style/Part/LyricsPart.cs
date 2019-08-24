using System.Xml.Serialization;

namespace NicoKaraParser.Model.Style.Part
{
    [XmlRoot(ElementName = "LyricsPart")]
    public class LyricsPart
    {
        [XmlElement(ElementName = "BeginTime")]
        public int BeginTime { get; set; }

        [XmlElement(ElementName = "EndTime")]
        public int EndTime { get; set; }

        [XmlElement(ElementName = "Lyrics")]
        public string Lyrics { get; set; }
    }
}
