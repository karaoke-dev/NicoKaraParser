using System.Xml.Serialization;

namespace NicoKaraParser.Model.Layout
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
