using System.Xml.Serialization;

namespace NicoKaraParser.Model.Title.Style
{
    [XmlRoot(ElementName = "TitleStyle")]
    public class TitleStyle
    {
        [XmlElement(ElementName = "Title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "KaraokeFontIndex")]
        public int KaraokeFontIndex { get; set; }

        [XmlElement(ElementName = "Continuous")]
        public bool Continuous { get; set; }
    }
}
