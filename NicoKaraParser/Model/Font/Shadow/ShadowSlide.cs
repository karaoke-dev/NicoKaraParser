using System.Xml.Serialization;

namespace NicoKaraParser.Model.Font.Shadow
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
