using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "ShadowSlide")]
    public class ShadowSlide
    {
        [XmlElement(ElementName = "X")]
        public string X { get; set; }
        [XmlElement(ElementName = "Y")]
        public string Y { get; set; }
    }
}
