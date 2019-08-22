using System.Xml.Serialization;
using System.Collections.Generic;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "TitleStyles")]
    public class TitleStyles
    {
        [XmlElement(ElementName = "TitleStyle")]
        public List<TitleStyle> TitleStyle { get; set; }
    }
}
