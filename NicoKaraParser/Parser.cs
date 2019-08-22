using NicoKaraParser.Model;
using System.Xml.Serialization;

namespace NicoKaraParser
{
    public class Parser : XmlSerializer
    {
        public Parser() :
            base(typeof(ProjectSettings))
        {

        }
    }
}
