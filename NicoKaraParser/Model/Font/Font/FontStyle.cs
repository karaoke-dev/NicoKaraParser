using System.Xml.Serialization;

namespace NicoKaraParser.Model.Font.Font
{
    public enum FontStyle
    {
        [XmlEnum("Bold")]
        Bold,

        [XmlEnum("Regular")]
        Regular
    }
}
