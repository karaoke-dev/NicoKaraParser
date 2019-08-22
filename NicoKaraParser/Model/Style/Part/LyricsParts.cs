using System.Collections.Generic;
using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "LyricsParts")]
    public class LyricsParts
    {
        [XmlElement(ElementName = "LyricsPart")]
        public List<LyricsPart> LyricsPart { get; set; }
    }
}
