using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using lab4.Shapes;

namespace lab4
{
    class Serializer
    {
        public static bool Flag = false;
        public static MethodInfo Method1 = null;
        public static MethodInfo Method2 = null;
        public static Type[] PersonTypes = { typeof(Circle), typeof(Ellipse), typeof(Square), typeof(Segment), typeof(Rectangle), typeof(Triangle) };
        public static void Serialize(object data, string file)
        {
            XmlSerializer xml = new XmlSerializer(data.GetType(), PersonTypes);
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, data);
            }

            if (Flag)
            {
                string file2 = file.Split('.')[0] + ".json";
                Method1.Invoke(null, new object[] { file, file2 });
            }
        }

        public static T Deserialize<T>(string file)
        {
            if (Flag)
            {
                string file2 = file.Split('.')[0] + ".json";
                if (!File.Exists(file) && File.Exists(file2))
                    Method2.Invoke(null, new object[] {file, file2});
            }
            XmlSerializer xml = new XmlSerializer(typeof(T), PersonTypes);
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                return (T)xml.Deserialize(fs);
            }
        }
    }
}
