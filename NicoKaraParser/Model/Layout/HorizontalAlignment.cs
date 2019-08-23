﻿using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    public enum HorizontalAlignment
    {
        [XmlEnum("Left")]
        Left,

        [XmlEnum("Center")]
        Center,

        [XmlEnum("Right")]
        Right,
    }
}