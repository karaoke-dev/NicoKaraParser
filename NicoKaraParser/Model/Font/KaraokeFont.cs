using System.Collections.Generic;
using System.Xml.Serialization;
using NicoKaraParser.Model.Font.Brush;
using NicoKaraParser.Model.Font.Font;
using NicoKaraParser.Model.Font.Shadow;

namespace NicoKaraParser.Model.Font
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
