using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "TitleStyle")]
    public class TitleStyle
    {
        [XmlElement(ElementName = "Title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "KaraokeFontIndex")]
        public string KaraokeFontIndex { get; set; }
        [XmlElement(ElementName = "Continuous")]
        public string Continuous { get; set; }
    }
}
