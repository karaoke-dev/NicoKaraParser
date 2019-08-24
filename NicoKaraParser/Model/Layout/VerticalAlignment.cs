using System.Xml.Serialization;

namespace NicoKaraParser.Model.Layout
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
