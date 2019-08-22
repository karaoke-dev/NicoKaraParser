using System.Xml.Serialization;

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

        [XmlElement(ElementName = "KaraokeFonts")]
        public KaraokeFonts KaraokeFonts { get; set; }

        [XmlElement(ElementName = "KaraokeLayouts")]
        public KaraokeLayouts KaraokeLayouts { get; set; }

        [XmlElement(ElementName = "KaraokeStyles")]
        public KaraokeStyles KaraokeStyles { get; set; }

        [XmlElement(ElementName = "TitleInfos")]
        public TitleInfos TitleInfos { get; set; }

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
