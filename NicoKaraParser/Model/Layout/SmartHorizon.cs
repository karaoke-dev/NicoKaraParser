using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    public enum SmartHorizon
    {
        [XmlEnum("None")]
        None,

        [XmlEnum("Single")]
        Single,

        [XmlEnum("Multi")]
        Multi,
    }
}
