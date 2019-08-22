using System.Collections.Generic;
using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "KaraokeFonts")]
    public class KaraokeFonts
    {
        [XmlElement(ElementName = "KaraokeFont")]
        public List<KaraokeFont> KaraokeFont { get; set; }
    }
}
