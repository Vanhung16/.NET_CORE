using System;
using System.Collections.Generic;

namespace NhapLieu
{
    class Program
    {
        static void insertDataWithWhile(List<int>list, int n)
        {
            int i = 0;
            while(i < n)
            {
                list.Add(int.Parse(Console.ReadLine()));
                i++;
            }
        }
        static void insertDataWithDo(List<int> list, int n)
        {
            int i = 0;
            do
            {
                list.Add(int.Parse(Console.ReadLine()));
                i++;
            } while (i < n);
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.WriteLine("Nhap so phan tu n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------Insert With while Loop----------------");
            insertDataWithWhile(list, n);
            Console.WriteLine("-------------Insert With Do While Loop----------------");
            insertDataWithDo(list, n);

        }
    }
}
