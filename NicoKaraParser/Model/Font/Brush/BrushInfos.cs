using System.Collections.Generic;
using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "BrushInfos")]
    public class BrushInfos
    {
        [XmlElement(ElementName = "BrushInfo")]
        public List<BrushInfo> BrushInfo { get; set; }
    }
}
