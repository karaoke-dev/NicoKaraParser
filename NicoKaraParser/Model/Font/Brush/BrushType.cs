using System.Xml.Serialization;

namespace NicoKaraParser.Model.Font.Brush
{
    public enum BrushType
    {
        [XmlEnum("Solid")]
        Solid,

        [XmlEnum("Gradient")]
        Gradient,

        [XmlEnum("MilleFeuille")]
        MilleFeuille
    }
}
