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
            MyCustomArray l = new MyCustomArray(5);
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
            l.Output();

            /* Array a = new Array[10];
             Array b = new Array[10];
             a.Clone();
             Object o;
             o.Equals(a);
             a.
             a = b;
             b[0] = 10; a[0] = 0 or 10 ?
            MyCustomArray myCustomArray = new MyCustomArray(5);
              int a = Convert.ToInt32(Console.ReadLine());
              int b = Convert.ToInt32(Console.ReadLine());
              try
              {
                  Console.WriteLine(DivideTwoNumbers(ref myCustomArray));
              }
              catch (DivideByZeroException)
              {
                  Console.WriteLine("Srsly?");
              }
             Console.ReadLine();
             return 0;*/

            //Figure f = new Figure();
            Circle c= new Circle(5);
            Rectangle r = new Rectangle(3, 4);
            Triangle t = new Triangle(3, 4, 5);

            List<Figure> list = new List<Figure>();
            list.Add(c);
            list.Add(r);
            list.Add(t);

            for(int i=0; i<list.Count; i++)
                Console.WriteLine(list[i]); 
            //Console.WriteLine(f.ToString());
            /*Console.WriteLine(c);
            Console.WriteLine(r);
            Console.WriteLine(t);*/
            Console.ReadLine();
            return 0;
        }

      /*  static double DivideTwoNumbers(ref MyCustomArray myCustom)
        {
            myCustom.AddValue(1);
            myCustom = null;
            *//*if (b == 0) throw new DivideByZeroException();
            return a * 1.0 / b;*//*
        }*/

        
        

    }
}
