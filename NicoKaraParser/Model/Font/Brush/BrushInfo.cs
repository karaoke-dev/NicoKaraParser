using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "BrushInfo")]
    public class BrushInfo
    {
        [XmlElement(ElementName = "Type")]
        public BrushType Type { get; set; }

        [XmlElement(ElementName = "GradientPositions")]
        public GradientPositions GradientPositions { get; set; }

        [XmlElement(ElementName = "SolidColorSave")]
        public int SolidColorSave { get; set; }

        [XmlElement(ElementName = "GradientColorsSave")]
        public GradientColorsSave GradientColorsSave { get; set; }
    }

}
