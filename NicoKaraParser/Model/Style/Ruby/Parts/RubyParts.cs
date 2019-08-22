using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "RubyParts")]
    public class RubyParts
    {
        [XmlElement(ElementName = "LyricsPart")]
        public LyricsPart LyricsPart { get; set; }
    }
}
