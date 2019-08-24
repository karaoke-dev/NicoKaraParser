using System.Xml.Serialization;

namespace NicoKaraParser.Model.Font.Font
{
    [XmlRoot(ElementName = "FontInfo")]
    public class FontInfo
    {
        [XmlElement(ElementName = "FontName")]
        public string FontName { get; set; }

        [XmlElement(ElementName = "FontStyle")]
        public FontStyle FontStyle { get; set; }

        [XmlElement(ElementName = "CharSize")]
        public int CharSize { get; set; }

        [XmlElement(ElementName = "EdgeSize")]
        public int EdgeSize { get; set; }
    }
}
