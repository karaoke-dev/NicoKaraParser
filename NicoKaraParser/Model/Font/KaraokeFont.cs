using System.Collections.Generic;
using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "KaraokeFont")]
    public class KaraokeFont
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlArray(ElementName = "BrushInfos")]
        public List<BrushInfo> BrushInfos { get; set; }

        [XmlArray(ElementName = "FontInfos")]
        public List<FontInfo> FontInfos { get; set; }

        [XmlElement(ElementName = "UseShadow")]
        public bool UseShadow { get; set; }

        [XmlElement(ElementName = "ShadowSlide")]
        public ShadowSlide ShadowSlide { get; set; }
    }
}
