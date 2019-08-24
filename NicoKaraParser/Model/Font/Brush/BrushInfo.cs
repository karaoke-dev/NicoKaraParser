using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "BrushInfo")]
    public class BrushInfo
    {
        [XmlElement(ElementName = "Type")]
        public BrushType Type { get; set; }

        [XmlArray(ElementName = "GradientPositions")]
        public List<float> GradientPositions { get; set; }

        /// <summary>
        /// Because it is hard to convert int into Color in xml parser,
        /// so make this property temporarily
        /// </summary>
        [XmlIgnore]
        public Color SolidColor { get; set; }

        [XmlElement(ElementName = "SolidColorSave")]
        public int SolidColorSave
        {
            get => SolidColor.ToArgb();
            set => SolidColor = Color.FromArgb(value);
        }

        /// <summary>
        /// Because it is hard to convert int into Color in xml parser,
        /// so make this property temporarily
        /// </summary>
        [XmlIgnore]
        public List<Color> GradientColors { get; set; }

        [XmlArray(ElementName = "GradientColorsSave")]
        public int[] GradientColorsSave
        {
            get => GradientColors?.Select(x => x.ToArgb()).ToArray();
            set => GradientColors = value?.Select(x => Color.FromArgb(x)).ToList();
        }
    }

}
