using System;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert Data edge a= ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("\nInsert Data edge b= ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("\nInsert Data edge c= ");
            float c = float.Parse(Console.ReadLine());

            while(a*b*c < 0 || a+b<=c || b + c <= a || a + c <= b)
            {
                Console.WriteLine( "sai");
                Console.Write("Insert Data edge a= ");
                a = float.Parse(Console.ReadLine());
                Console.Write("\nInsert Data edge b= ");
                b = float.Parse(Console.ReadLine());
                Console.Write("\nInsert Data edge c= ");
                c = float.Parse(Console.ReadLine());
            }
            float p = a + b + c;
            float s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Chu vi p= " + p);
            Console.WriteLine("Dien tich s= " + s);

        }
    }
}
