using System;
using System.Collections.Generic;

namespace TinhToan
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Nhap so thuc a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thuc b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nNhap chuoi phep tinh:");
            string pt = Console.ReadLine();
            Console.WriteLine("KQ");
            string[] subs = pt.Split();
            string choose= "";
            foreach (string item in subs)
            {
                if (item.Contains("+") || item.Contains("-") || item.Contains("*") || item.Contains("/"))
                {
                    choose = item;
                }
                else
                {
                    Console.WriteLine("Khong tinh duoc");
                    break;
                }
            }
            switch (choose)
            {
                case "+":
                    Console.WriteLine("Tong hai so a + b = " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("Tong hai so a - b = " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("Tong hai so a * b = " + (a * b));
                    break;
                case "/":
                    Console.WriteLine("Tong hai so a / b = " + (a / b));
                    break;
                default:
                    Console.WriteLine("Khong tinh duoc");
                    break;
            }
        }
    }
}
