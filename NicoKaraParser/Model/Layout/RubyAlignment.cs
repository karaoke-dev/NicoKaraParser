using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    public enum RubyAlignment
    {
        [XmlEnum("Auto")]
        Auto,

        [XmlEnum("Center")]
        Center,

        [XmlEnum("EqualSpace")]
        EqualSpace
    }
}
