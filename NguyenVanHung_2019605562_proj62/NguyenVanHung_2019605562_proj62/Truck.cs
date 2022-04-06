using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHung_2019605562_proj62
{
    class Truck:Vehicles
    {
        public int truckload { get; set; }

        public Truck()
        {
        }

        public Truck(int truck, string id, string maker, string model, int year, double price) : base(id, maker, model, year, price)
        {
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap tai trong: ");
            truckload = int.Parse(Console.ReadLine());
        }
        public static void inTieuDe()
        {
            Vehicles.inTieuDe();
            Console.WriteLine("{0,10}","truckload");
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,10}",truckload);
        }
    }
}
