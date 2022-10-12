using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

       
        static int Main(string[] args)
        {
            /*foreach (var i in args) Console.WriteLine(i);
            NotMain();*/
            ArrayList l = new ArrayList(5);
            l.AddValue(1);
            l.AddValue(2);
            l.AddValue(3);
            l.AddValue(4);
            l.AddValue(5);
            l.AddValue(6);
            l.Output();
            Console.WriteLine(l.FindFirstElement(3));
            l.RemoveElementAt(2);
            l.Output();
            l.RemoveElement(5);
            l.Output();
            /* int a = Convert.ToInt32(Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());
             try
             {
                 Console.WriteLine(DivideTwoNumbers(a,b));
             }
             catch (DivideByZeroException)
             {
                 Console.WriteLine("Srsly?");
             }*/
             Console.ReadLine();
            return 0;
        }

        static double DivideTwoNumbers(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a * 1.0 / b;
        }

    }
}
