using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De02
{
    class Candidate : Examinee,IComparable
    {
        public int address { get; set; }
        public float prioritized { get; set; }

        public int CompareTo(object obj)
        {
            Candidate x = (Candidate)obj;
            return (int)(this.Total() - x.Total());
        }


        public void Input()
        {

            Console.Write("Nhap id: ");
            id = Console.ReadLine();
            Console.Write("\nNhap fullname: ");
            fullname = Console.ReadLine();

            Console.Write("\nNhap math: ");

            math = float.Parse(Console.ReadLine());

            Console.Write("\nNhap physical: ");
            physical = float.Parse(Console.ReadLine());
            Console.Write("\nNhap address: ");
            address = int.Parse(Console.ReadLine());
            if (address == 1)
            {
                prioritized = 0;
            }
            else if (address == 2)
            {
                prioritized = 1;
            }
            else if (address == 3)
            {
                prioritized = 2;
            }
            else
            {
                Console.WriteLine("dia chi khong hop le");
            }

        }
        public static void inTD()
        {
            Examinee.inTD();
            Console.WriteLine("{0,10}{1,10}{2,10}","adress","prioritized","total");

        }
        public void Output()
        {
            Console.WriteLine("{0,5}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}", id, fullname, math, physical, address, prioritized,Total());

        }

        public override float Total()
        {
            return base.Total() + prioritized;
        }
    }
}
