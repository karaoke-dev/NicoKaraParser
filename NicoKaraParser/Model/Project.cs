using System.Collections.Generic;
using System.Xml.Serialization;
using NicoKaraParser.Model.Font;
using NicoKaraParser.Model.Layout;
using NicoKaraParser.Model.Style;
using NicoKaraParser.Model.Title;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "ProjectSettings")]
    public class Project
    {
        [XmlElement(ElementName = "AppVer")]
        public string AppVer { get; set; }

        [XmlElement(ElementName = "IsDefaultStyleNeeded")]
        public bool IsDefaultStyleNeeded { get; set; }

        [XmlElement(ElementName = "LyricsPath")]
        public string LyricsPath { get; set; }

        [XmlElement(ElementName = "LyricsRelativePath")]
        public string LyricsRelativePath { get; set; }

        [XmlArray(ElementName = "KaraokeFonts")]
        public List<KaraokeFont> KaraokeFonts { get; set; }

        [XmlArray(ElementName = "KaraokeLayouts")]
        public List<KaraokeLayout> KaraokeLayouts { get; set; }

        [XmlArray(ElementName = "KaraokeStyles")]
        public List<KaraokeStyle> KaraokeStyles { get; set; }

        [XmlArray(ElementName = "TitleInfos")]
        public List<TitleInfo> TitleInfos { get; set; }

        [XmlElement(ElementName = "DestFormat")]
        public string DestFormat { get; set; }

        [XmlElement(ElementName = "DoubleFrame")]
        public bool DoubleFrame { get; set; }

        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }

        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
    }
}
