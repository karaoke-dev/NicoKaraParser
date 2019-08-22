using System.Xml.Serialization;
using System.Collections.Generic;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "KaraokeStyles")]
    public class KaraokeStyles
    {
        [XmlElement(ElementName = "KaraokeStyle")]
        public List<KaraokeStyle> KaraokeStyle { get; set; }
    }
}
