using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    public enum HorizontalAlignment
    {
        [XmlEnum("Solid")]
        Left,

        [XmlEnum("Center")]
        Center,

        [XmlEnum("Right")]
        Right,
    }
}
