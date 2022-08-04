using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OVERLOAD-1");
            Console.WriteLine(Area(int.Parse(Console.ReadLine())));
            Console.WriteLine("OVERLAOD-2");
            Console.WriteLine(Area(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine("OVERLAOD-3");
            Console.WriteLine(Area(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine("OVERLAOD-4");
            Console.WriteLine(Area(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        static int Area(int r)
        {
           int   s = 3 * r * r;
            return s;
            
        }
        static int Area(int a, int b)
        {
            
           int s = a * b;
            return s;
        }
        static int Area(int a,int b,int c)
        {
            int s = 2 * (a * b + a * c + b * c);
            return s;
        }
     
        static int Area(int a, int c, int b,int r)
        {
            int p = (a + b + c) / 2;
            int s = p * r;
            return s;
        }
    }
}
