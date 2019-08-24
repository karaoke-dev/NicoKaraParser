using System.Xml.Serialization;
using NicoKaraParser.Model.Style.Part;

namespace NicoKaraParser.Model.Style.Ruby.Parts
{
    [XmlRoot(ElementName = "RubyParts")]
    public class RubyParts
    {
        [XmlElement(ElementName = "LyricsPart")]
        public LyricsPart LyricsPart { get; set; }
    }
}
