using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace XMLToJSON
{
    public class XmltoJson
    {
        public static void Convert(string pathXml, string pathJson)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(pathXml);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            File.WriteAllText(pathJson, jsonText);
        }
    }
}
