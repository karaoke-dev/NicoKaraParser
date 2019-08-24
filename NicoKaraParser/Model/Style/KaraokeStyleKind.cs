using System.Xml.Serialization;

namespace NicoKaraParser.Model.Style
{
    public enum KaraokeStyleKind
    {
        [XmlEnum("Lyrics")]
        Lyrics,

        [XmlEnum("Empty")]
        Empty
    }
}
