using NicoKaraParser.Model;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NicoKaraParser
{
    public class Parser : XmlSerializer<ProjectSettings>
    {

    }

    public class XmlSerializer<T> : XmlSerializer
        where T : class
    {
        public XmlSerializer() :
            base(typeof(T))
        {

        }

        public new T Deserialize(TextReader textReader) => base.Deserialize(textReader) as T;

        public new T Deserialize(Stream stream) => base.Deserialize(stream) as T;

        public new T Deserialize(XmlReader xmlReader, XmlDeserializationEvents events) => base.Deserialize(xmlReader,events) as T;

        public new T Deserialize(XmlReader xmlReader, string encodingStyle) => base.Deserialize(xmlReader, encodingStyle) as T;

        public new T Deserialize(XmlReader xmlReader) => base.Deserialize(xmlReader) as T;
    }
}
