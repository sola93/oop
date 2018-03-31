using System;
using System.Collections.Generic;
using System.Reflection;
using lab4.Dialogs;
using lab4.Strategy;

namespace lab4
{
    public class LoadPlugins
    {
        public static Dictionary<string, object> Calcs = new Dictionary<string, object>();
        private static readonly string _path = "../../Dll/Angle.dll";
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
    }
}
