using System;
using System.Reflection;
using lab4.Dialogs;
using lab4.Strategy;

namespace lab4
{
    public class LoadPlugins
    {
        private static readonly string _path = "../../Dll/Angle.dll";
        private static readonly string _path3 = "../../Dll/Rhomb.dll";
        private static readonly string _path1 = "../../Dll/XMLToJSON.dll";
        private static readonly string _path2 = "../../Dll/JSONToXML.dll";
        //Загрузка плагинов
        public static void LoadAngle(Form1 form)
        {
            Assembly assembly = Assembly.LoadFrom(_path);
            var type = assembly.GetType("Angle.AngleDialog");
            var obj = Activator.CreateInstance(type);
            var type2 = assembly.GetType("Angle.DrawPolyline");
            var obj2 = Activator.CreateInstance(type2);
            Form1.Dialogs.Add("Angle",(FigureDialog)obj);
            Form1.Draws.Add("Angle",(IDraw)obj2);
            form.listBox1.Items.Add("Angle");
            Array.Resize(ref Serializer.PersonTypes, Serializer.PersonTypes.Length + 1);
            Serializer.PersonTypes[Serializer.PersonTypes.Length - 1] = assembly.GetType("Angle.Angle");
        }

        public static void LoadXmlJsonConverter(string file)
        {
            Assembly assembly = Assembly.LoadFrom(_path1);
            var type = assembly.GetType("XMLToJSON.XmltoJson");
            Serializer.Method1 = type.GetMethod("Convert");

            Assembly assembly2 = Assembly.LoadFrom(_path2);
            var type2 = assembly2.GetType("JSONToXML.JsontoXml");
            Serializer.Method2 = type2.GetMethod("Convert");

            Serializer.Flag = true;
        }

        public static void LoadRhomb(Form1 form)
        {
            Assembly assembly = Assembly.LoadFrom(_path3);
            Type type = assembly.GetType("Rhomb.RhombDialog");
            AdapterDialog dialog = new AdapterDialog(type);
            Form1.Dialogs.Add("Rhomb", dialog);
            form.listBox1.Items.Add("Rhomb");
            Form1.Draws.Add("Adapter", new PolygonDraw());
            Array.Resize(ref Serializer.PersonTypes, Serializer.PersonTypes.Length + 1);
            Serializer.PersonTypes[Serializer.PersonTypes.Length - 1] = typeof(Adapter);
        }
    }
}
