using System.Collections.Generic;
using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "KaraokeLayouts")]
    public class KaraokeLayouts
    {
        [XmlElement(ElementName = "KaraokeLayout")]
        public List<KaraokeLayout> KaraokeLayout { get; set; }
    }
}
