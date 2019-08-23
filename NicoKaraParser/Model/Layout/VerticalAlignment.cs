using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    public enum VerticalAlignment
    {
        [XmlEnum("Top")]
        Top,

        [XmlEnum("Center")]
        Center,

        [XmlEnum("Bottom")]
        Bottom,
    }
}
