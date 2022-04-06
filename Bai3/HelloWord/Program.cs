using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap vao 2 so.");
            Console.Write("\n a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a+"+"+ b + " = " + (a+b));
        }
    }
}
