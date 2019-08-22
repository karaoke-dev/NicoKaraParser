using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "FontInfo")]
    public class FontInfo
    {
        [XmlElement(ElementName = "FontName")]
        public string FontName { get; set; }
        [XmlElement(ElementName = "FontStyle")]
        public string FontStyle { get; set; }
        [XmlElement(ElementName = "CharSize")]
        public string CharSize { get; set; }
        [XmlElement(ElementName = "EdgeSize")]
        public string EdgeSize { get; set; }
    }
}
