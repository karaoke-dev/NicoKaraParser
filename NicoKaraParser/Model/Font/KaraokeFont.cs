using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "KaraokeFont")]
    public class KaraokeFont
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "BrushInfos")]
        public BrushInfos BrushInfos { get; set; }

        [XmlElement(ElementName = "FontInfos")]
        public FontInfos FontInfos { get; set; }

        [XmlElement(ElementName = "UseShadow")]
        public bool UseShadow { get; set; }

        [XmlElement(ElementName = "ShadowSlide")]
        public ShadowSlide ShadowSlide { get; set; }
    }
}
