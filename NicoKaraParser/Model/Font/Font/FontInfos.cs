using System.Collections.Generic;
using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "FontInfos")]
    public class FontInfos
    {
        [XmlElement(ElementName = "FontInfo")]
        public List<FontInfo> FontInfo { get; set; }
    }
}
