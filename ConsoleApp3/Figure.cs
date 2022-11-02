using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal abstract class Figure
    {
        public double area;
        public double perimetr;
        public abstract void CalculateArea();
        public override string ToString()
        {
            return "It's Figure with area equals " + area;
        }
    }
}
