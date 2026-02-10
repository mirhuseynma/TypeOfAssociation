using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfAssociation.Practice
{
    public class Circle:Shape
    {
        public double Radius;

        public Circle(string color,double radius ):base(color) 
        {
            Radius = radius;
            Area = 3.14 * radius * radius;
        }
    }
}
