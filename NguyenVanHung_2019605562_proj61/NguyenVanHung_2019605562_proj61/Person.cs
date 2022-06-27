using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHung_2019605562_proj61
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public Person(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public Person()
        {
        }
        public virtual void input()
        {
            Console.WriteLine("Nhap id: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            address = Console.ReadLine();
        }
        public virtual void output()
        {
            Console.Write("{0,-5}{1,-15}{2,-15}",id, name, address);
        }
        public static void Title()
        {
            Console.Write("{0,-5}{1,-15}{2,-15}", "id", "name", "address");
        }
    }
}
