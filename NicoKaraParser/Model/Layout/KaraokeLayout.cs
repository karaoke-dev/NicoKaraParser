using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "KaraokeLayout")]
    public class KaraokeLayout
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Continuous")]
        public string Continuous { get; set; }
        [XmlElement(ElementName = "HorizontalAlignment")]
        public string HorizontalAlignment { get; set; }
        [XmlElement(ElementName = "HorizontalMargin")]
        public string HorizontalMargin { get; set; }
        [XmlElement(ElementName = "SmartHorizon")]
        public string SmartHorizon { get; set; }
        [XmlElement(ElementName = "VerticalAlignment")]
        public string VerticalAlignment { get; set; }
        [XmlElement(ElementName = "VerticalMargin")]
        public string VerticalMargin { get; set; }
        [XmlElement(ElementName = "LyricsInterval")]
        public string LyricsInterval { get; set; }
        [XmlElement(ElementName = "RubyInterval")]
        public string RubyInterval { get; set; }
        [XmlElement(ElementName = "RubyAlignment")]
        public string RubyAlignment { get; set; }
        [XmlElement(ElementName = "RubyMargin")]
        public string RubyMargin { get; set; }
    }
}
