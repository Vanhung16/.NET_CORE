using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHung_2019605562_proj62
{
    class Vehicles : IVehicle,IComparable
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public Vehicles()
        {
        }

        public Vehicles(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public Vehicles(string id)
        {
            this.id = id;
        }

        public virtual void Input()
        {
            Console.Write("Nhap ma dinh danh: ");
            id = Console.ReadLine();
            Console.Write("Nhap hang san xuat: ");
            maker = Console.ReadLine();
            Console.Write("Nhap ten xe: ");
            model = Console.ReadLine();
            Console.Write("Nhap nam san xuat: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tien: ");
            price = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.Write("{0,-5}{1,-10}{2,-10}{3,5}{4,7}", id, maker, model, year, price);
        }
        public static void inTieuDe()
        {
            Console.Write("{0,-5}{1,-10}{2,-10}{3,5}{4,7}", "id", "maker", "model", "year", "price");
        }

        public override bool Equals(object obj)
        {
            return obj is Vehicles vehicles &&
                   id == vehicles.id;
        }

        public override string ToString()
        {
            return string.Format("{0,-5}{1,-10}{2,-10}{3,5}{4,7}", id, maker, model, year, price);
        }

        public int CompareTo(object obj)
        {
            Vehicles x = (Vehicles) obj;
            return (int)(this.price - x.price);
        }
    }
    class sapxepnam : IComparer<Vehicles>
    {
        public int Compare(Vehicles x, Vehicles y)
        {
            return x.year - y.year;
        }
    }
}
