using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "TitleInfo")]
    public class TitleInfo
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "KaraokeLayoutIndex")]
        public string KaraokeLayoutIndex { get; set; }
        [XmlElement(ElementName = "BeginTime")]
        public string BeginTime { get; set; }
        [XmlElement(ElementName = "EndTime")]
        public string EndTime { get; set; }
        [XmlElement(ElementName = "LineInterval")]
        public string LineInterval { get; set; }
        [XmlElement(ElementName = "ShowRuby")]
        public string ShowRuby { get; set; }
        [XmlElement(ElementName = "TitleStyles")]
        public TitleStyles TitleStyles { get; set; }
    }
}
