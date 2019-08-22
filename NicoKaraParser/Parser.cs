using NicoKaraParser.Model;
using System.IO;
using System.Xml.Serialization;

namespace NicoKaraParser
{
    public class Parser
    {
        public T Deserialize<T>(string input) where T : ProjectSettings
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public string Serialize<T>(T ObjectToSerialize) where T : ProjectSettings
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }
    }
}
