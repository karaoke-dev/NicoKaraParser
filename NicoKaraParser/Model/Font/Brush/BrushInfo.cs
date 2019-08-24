using System.Collections.Generic;
using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "BrushInfo")]
    public class BrushInfo
    {
        [XmlElement(ElementName = "Type")]
        public BrushType Type { get; set; }

        [XmlArray(ElementName = "GradientPositions")]
        public List<float> GradientPositions { get; set; }

        [XmlElement(ElementName = "SolidColorSave")]
        public int SolidColorSave { get; set; }

        [XmlArray(ElementName = "GradientColorsSave")]
        public List<int> GradientColorsSave { get; set; }
    }

}
