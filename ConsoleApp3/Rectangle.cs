using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Rectangle: Figure
    {
        public double sideA;
        public double sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.CalculateArea();
        }

        public override void CalculateArea()
        {
            this.area = sideA*sideB;
        }

        public override string ToString()
        {
            return "I'm rectangle with sides = " + sideA + " and " + sideB + "and area = " + area;
        }
         
    }
}
