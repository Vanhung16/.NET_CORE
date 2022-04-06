using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi");
            string chuoi = Console.ReadLine();
            string reverse = string.Empty;
            for(int i = chuoi.Length - 1 ; i >= 0 ; i--) 
            {
                reverse += chuoi[i];
            }
            if(chuoi == reverse)
            {
                Console.WriteLine("Doi xung");
            }
            Console.WriteLine("Khong doi xung");
        }
    }
}
