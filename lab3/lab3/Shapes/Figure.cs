using System;
using System.Xml.Serialization;

namespace lab3.Shapes
{
    public abstract class Figure
    {
        public abstract void Edit(params object[] parameters);
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
