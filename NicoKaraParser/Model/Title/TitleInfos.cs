using System.Xml.Serialization;
using System.Collections.Generic;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "TitleInfos")]
    public class TitleInfos
    {
        [XmlElement(ElementName = "TitleInfo")]
        public List<TitleInfo> TitleInfo { get; set; }
    }
}
