using System.Xml.Serialization;
using System.Collections.Generic;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "ApplyRubies")]
    public class ApplyRubies
    {
        [XmlElement(ElementName = "RubyInfo")]
        public List<RubyInfo> RubyInfo { get; set; }
    }
}
