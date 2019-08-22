using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "ShadowSlide")]
    public class ShadowSlide
    {
        [XmlElement(ElementName = "X")]
        public int X { get; set; }
        [XmlElement(ElementName = "Y")]
        public int Y { get; set; }
    }
}
