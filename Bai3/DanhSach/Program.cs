using System;
using System.Collections.Generic;

namespace DanhSach
{
    class Program
    {
        static void viewlist(List<float> list)
        {
            foreach(var item in list)
            {
                Console.Write(item + "\t");
            }
        }
       
        static void Main(string[] args)
        {
            List<float> list = new List<float>();
            for(int i = 0; i< 5; i++)
            {
                list.Add(float.Parse(Console.ReadLine()));
            }
            viewlist(list);
            Console.WriteLine("\nsort");
            list.Sort();
            viewlist(list);
            Console.WriteLine("\ncheck");
            
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            if (list.Count > 0)
            {
                viewlist(list);
            } else
            {
                Console.WriteLine("\nKHONG CON PHAN TU NAO !😒");
            }
            Console.WriteLine("\n------------------------------------");
            Console.Write("Nhap so bat ky: ");
            float x = float.Parse(Console.ReadLine());
            int index = 0;
            for(int i = 0; i < list.Count; i++)
            {
                if(x > list[i])
                {
                    index = i;
                }
            }
            Console.WriteLine("view list"); ;
            list.Insert(index, x);
            viewlist(list);

        }
    }
}
