using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    public enum KaraokeStyleKind
    {
        [XmlEnum("Lyrics")]
        Lyrics,

        [XmlEnum("Empty")]
        Empty
    }
}
