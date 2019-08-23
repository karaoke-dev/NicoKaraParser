using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    public enum VerticalAlignment
    {
        [XmlEnum("Top")]
        Top,

        [XmlEnum("Middle")]
        Middle,

        [XmlEnum("Bottom")]
        Bottom,
    }
}
