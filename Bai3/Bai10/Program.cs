using System;
using System.IO;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            
             using (StreamWriter sw = new StreamWriter(@"E:\KI2_NAM3\.NET\test_target.txt"))
            {
                int count = 0;
                using (StreamReader sr = new StreamReader(@"E:\KI2_NAM3\.NET\test.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line.ToUpper());
                        String[] words = line.Split(' ');
                        count += words.Length;
                    }
                   
                }
            Console.WriteLine("count word in file test.txt");
                sw.WriteLine(count);
            Console.WriteLine(count);
            }
            

        }
    }
}
