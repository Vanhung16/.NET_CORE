using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHung_2019605562_proj62
{
    class Car:Vehicles
    {
        public string color { get; set; }

        public Car()
        {
        }

        public Car( string color, string id, string maker, string model, int year, double price) : base(id, maker, model, year, price)
        {
            this.color = color;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap mau: ");
            color = Console.ReadLine();
        }

        public static void inTieuDe()
        {
            Vehicles.inTieuDe();
            Console.WriteLine("{0,10}","color");

        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,10}", color);
        }
    }
}
