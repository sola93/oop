using System;
using System.IO;
using System.Xml.Serialization;
using lab4.Shapes;

namespace lab4
{
    class Serializer
    {
        public static Type[] PersonTypes = { typeof(Circle), typeof(Ellipse), typeof(Square), typeof(Segment), typeof(Rectangle), typeof(Triangle) };
        public static void Serialize(object data, string file)
        {
            XmlSerializer xml = new XmlSerializer(data.GetType(), PersonTypes);
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, data);
            }
        }

        public static T Deserialize<T>(string file)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T), PersonTypes);
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                return (T)xml.Deserialize(fs);
            }
        }
    }
}
