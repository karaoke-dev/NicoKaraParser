using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    public enum BrushType
    {
        [XmlEnum("Solid")]
        Solid,

        [XmlEnum("Gradient")]
        Gradient
    }
}
