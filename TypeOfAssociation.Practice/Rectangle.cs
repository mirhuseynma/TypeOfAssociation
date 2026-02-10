using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfAssociation.Practice
{
    public class Rectangle:Circle
    {
        public int Length;

        public Rectangle(string color, double radius,int length) : base(color, radius)
        {
            Length = length;
            Area = length * length;
        }
    }
}
