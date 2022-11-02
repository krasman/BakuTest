using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Circle : Figure
    {
        
        public double radius { get; }
        public Circle(double radius)
        {
            this.radius = radius;
            this.CalculateArea();
        }

        public override string ToString()
        {
            return "I'm circle with radius = " + radius + " and area = " + area;
        }

        public override void CalculateArea()
        {
            this.area= Math.PI * radius * radius;
        }
    }
}
