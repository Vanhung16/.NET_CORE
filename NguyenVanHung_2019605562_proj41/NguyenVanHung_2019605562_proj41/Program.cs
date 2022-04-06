using System;

namespace NguyenVanHung_2019605562_proj41
{
    class Program
    {
        class Person
        {
            public string id { get; set; }
            public string  name { get; set; }
            public int tuoi { get; set; }
            public string email { get; set; }
            public string address { get; set; }

            public Person() { }
            public Person(string id,string name, int tuoi, string email,string address)
            {
                this.id = id;
                this.name = name;
                this.tuoi = tuoi;
                this.email = email;
                this.address = address;
            }
            public override string ToString()
            {
                return string.Format("{0,-8}{1,-15}{2,-5}{3,30}{4,20}",id, name, tuoi,email,address);
            }
            public void checkAge()
            {
                if(tuoi < 18)
                {
                    Console.WriteLine("ban con nho");
                }
                else
                {
                    Console.WriteLine("ban du tuoi bau cu");
                }
            }
            public void input()
            {
                Console.WriteLine("Nhap id:");
                id = Console.ReadLine();
                Console.WriteLine("Nhap ten:");
                name = Console.ReadLine();
                Console.WriteLine("Nhap tuoi:");
                tuoi = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap mail:");
                email = Console.ReadLine();
                Console.WriteLine("Nhap dia chi:");
                address = Console.ReadLine();
            }
            public void output()
            {
                Console.WriteLine("{0,-8}{1,-15}{2,-10}{3,30}{4,20}",id, name,tuoi,email,address);
            }
        }
        static void Main(string[] args)
        {
            Person a = new Person();
           // a.input();
            //Console.WriteLine("{0,-8}{1,-15}{2,-10}{3,30}{4,20}", "id", "name", "tuoi", "email", "address");
           // a.output();
            Console.WriteLine("\n------------------------------------");
            Circle c = new Circle(3);
            Console.WriteLine("Dien tich hinh tron "+ c.Area());
            Console.WriteLine("Chu vi hinh tron "+ c.Perimater());
            Console.WriteLine("\n------------------------------------");
            Student s = new Student("1","Van Hung",10);
            Console.WriteLine( s);
        }
    }
}
