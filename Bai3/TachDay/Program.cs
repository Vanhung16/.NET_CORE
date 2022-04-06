using System;
using System.Collections.Generic;

namespace TachDay
{
    class Program
    {
        static List<int> nhapday(List<int> list,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu "+ (i+1) + " cua day");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return list;
        }
        static void tachdaychanle(List<int> list,int n)
        {
            List<int> listchan = new List<int>();
            List<int> listle = new List<int>();
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    listchan.Add(item);
                }
                else
                {
                    listle.Add(item);
                }
            }
            foreach(var item in listchan)
            {
                Console.Write(item + "\t");

            }
            
              Console.WriteLine("\n");
             foreach (var item in listle)
             {
                 Console.Write(item + "\t");

             }
             
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Nhap so phan tu mang");
            int n = Convert.ToInt32(Console.ReadLine());
            nhapday(list,n);
            Console.WriteLine("KQ");
            tachdaychanle(list, n);

        }
    }
}
