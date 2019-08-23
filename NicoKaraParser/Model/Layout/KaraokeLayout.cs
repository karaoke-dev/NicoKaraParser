using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "KaraokeLayout")]
    public class KaraokeLayout
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Continuous")]
        public bool Continuous { get; set; }

        [XmlElement(ElementName = "HorizontalAlignment")]
        public HorizontalAlignment HorizontalAlignment { get; set; }

        [XmlElement(ElementName = "HorizontalMargin")]
        public int HorizontalMargin { get; set; }

        [XmlElement(ElementName = "SmartHorizon")]
        public string SmartHorizon { get; set; }

        [XmlElement(ElementName = "VerticalAlignment")]
        public VerticalAlignment VerticalAlignment { get; set; }

        [XmlElement(ElementName = "VerticalMargin")]
        public int VerticalMargin { get; set; }

        [XmlElement(ElementName = "LyricsInterval")]
        public int LyricsInterval { get; set; }

        [XmlElement(ElementName = "RubyInterval")]
        public int RubyInterval { get; set; }

        [XmlElement(ElementName = "RubyAlignment")]
        public string RubyAlignment { get; set; }

        [XmlElement(ElementName = "RubyMargin")]
        public int RubyMargin { get; set; }
    }
}
