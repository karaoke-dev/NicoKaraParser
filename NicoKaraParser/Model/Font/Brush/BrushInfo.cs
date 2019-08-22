using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "BrushInfo")]
    public class BrushInfo
    {
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "GradientPositions")]
        public GradientPositions GradientPositions { get; set; }
        [XmlElement(ElementName = "SolidColorSave")]
        public string SolidColorSave { get; set; }
        [XmlElement(ElementName = "GradientColorsSave")]
        public GradientColorsSave GradientColorsSave { get; set; }
    }

}
