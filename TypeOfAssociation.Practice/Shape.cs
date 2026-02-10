using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfAssociation.Practice
{
    public class Shape
    {
        public string Color;
        public double Area;

        public Shape(string color)
        {
            Color = color;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Color: {Color}, area: {Area}");
        }
    }
}
