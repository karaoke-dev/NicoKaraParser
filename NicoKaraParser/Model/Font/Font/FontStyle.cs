using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    public enum FontStyle
    {
        [XmlEnum("Bold")]
        Bold,

        [XmlEnum("Regular")]
        Regular
    }
}
