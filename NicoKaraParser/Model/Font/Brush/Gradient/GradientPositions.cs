using System.Collections.Generic;
using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "GradientPositions")]
    public class GradientPositions
    {
        [XmlElement(ElementName = "float")]
        public List<float> Float { get; set; }
    }
}
