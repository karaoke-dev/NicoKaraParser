using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "TitleInfo")]
    public class TitleInfo
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "KaraokeLayoutIndex")]
        public int KaraokeLayoutIndex { get; set; }

        [XmlElement(ElementName = "BeginTime")]
        public int BeginTime { get; set; }

        [XmlElement(ElementName = "EndTime")]
        public int EndTime { get; set; }

        [XmlElement(ElementName = "LineInterval")]
        public int LineInterval { get; set; }

        [XmlElement(ElementName = "ShowRuby")]
        public bool ShowRuby { get; set; }

        [XmlElement(ElementName = "TitleStyles")]
        public TitleStyles TitleStyles { get; set; }
    }
}
