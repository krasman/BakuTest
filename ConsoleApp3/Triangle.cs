using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Triangle: Figure
    {
        public double sideA;
        public double sideB;
        public double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.CalculateArea();
        }

        public override void CalculateArea()
        {
            double pp = (sideA + sideB + sideC)/2;
            this.area = Math.Sqrt(pp*(pp - sideA) * (pp - sideB) * (pp - sideC));
        }

        public override string ToString()
        {
            return "I'm triangle with sides = " + sideA + " and " + sideB + " and " + sideC + ". Area = " + area;
        }
    }
}
