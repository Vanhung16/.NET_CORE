using System;
using System.Collections.Generic;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu n= ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int item in list)
            {
                if (item % 2 != 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine("KQ");
            Console.Write(sum);
        }
    }
}
