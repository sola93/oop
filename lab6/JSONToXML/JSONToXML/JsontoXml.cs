using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONToXML
{
    public class JsontoXml
    {
        public static void Convert(string pathXml, string pathJson)
        {
            JObject o1 = JObject.Parse(File.ReadAllText(pathJson));
            XmlDocument doc = JsonConvert.DeserializeXmlNode(o1.ToString());
            doc.Save(pathXml);
        }
    }
}
