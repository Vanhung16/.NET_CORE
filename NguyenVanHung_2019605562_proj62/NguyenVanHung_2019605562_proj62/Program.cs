using System;
using System.Collections.Generic;

namespace NguyenVanHung_2019605562_proj62
{
    class Program
    {
        static int choose;
        static List<Vehicles> list = new List<Vehicles>();
        public static void nhapdl()
        {
            for(int i = 0; i < 1; i++)
            {
                Console.WriteLine("Nhap thong tin car thu "+(i+1));
                Car x = new Car();
                x.Input();
                list.Add(x);
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Nhap thong tin truck thu " + (i + 1));
                Truck x = new Truck();
                x.Input();
                list.Add(x);
            }
        }
        public static void hienthi()
        {
            Car.inTieuDe();
            foreach (Vehicles item in list)
            {
                if(item is Car)
                {
                    item.Output();
                }
                
            }
            Truck.inTieuDe();
            foreach (Vehicles item in list)
            {
                if (item is Truck)
                {
                    item.Output();
                }
            }
        }
        public static void timkiemtheoId()
        {
            Console.WriteLine("Nhap id can tim: ");
            string id = Console.ReadLine();
            Vehicles x = null;
            foreach(Vehicles item in list)
            {
                if(item.id == id)
                {
                    x = item;
                }
            }
            if(x == null)
            {
                Console.WriteLine("khong ton tai id trong danh sach");
            }
            else
            {
                if(x is Car)
                {
                    Car.inTieuDe();
                    x.Output();
                }
                if (x is Truck)
                {
                    Truck.inTieuDe();
                    x.Output();
                }

            }
        }
        public static void timkiemtheoMaker()
        {
            Console.WriteLine("Nhap maker can tim: ");
            string maker = Console.ReadLine();
            Vehicles x = null;
            foreach (Vehicles item in list)
            {
                if (item.maker == maker)
                {
                    x = item;
                }
            }
            if (x == null)
            {
                Console.WriteLine("khong ton tai maker trong danh sach");
            }
            else
            {
                if (x is Car)
                {
                    Car.inTieuDe();
                    x.Output();
                }
                if (x is Truck)
                {
                    Truck.inTieuDe();
                    x.Output();
                }
            }
        }
        public static void sapXepPrice()
        {
            list.Sort();
            Car.inTieuDe();
            foreach (Vehicles item in list)
            {
                if (item is Car)
                {
                    item.Output();
                }

            }
            Truck.inTieuDe();
            foreach (Vehicles item in list)
            {
                if (item is Truck)
                {
                    item.Output();
                }
            }
        }
        public static void sapXepYear()
        {

            list.Sort(new sapxepnam());
            Car.inTieuDe();
            foreach (Vehicles item in list)
            {
                if (item is Car)
                {
                    item.Output();
                }

            }
            Truck.inTieuDe();
            foreach (Vehicles item in list)
            {
                if (item is Truck)
                {
                    item.Output();
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\t\tNhap lua chon chuc nang");
                    Console.WriteLine("\t\t1.Nhap DL");
                    Console.WriteLine("\t\t2.Hien thi danh sach");
                    Console.WriteLine("\t\t3.Tim kiem theo Id");
                    Console.WriteLine("\t\t4.Tim kiem theo maker");
                    Console.WriteLine("\t\t5.Sap xep theo price");
                    Console.WriteLine("\t\t6.Sap xep theo year");
                    Console.WriteLine("\t\t7.ket thuc");
                    int temp = int.Parse(Console.ReadLine());
                    if (temp < 0) throw new Exception();
                    choose = temp;
                    switch (choose)
                    {
                        case 1:
                            nhapdl();
                            break;
                        case 2:
                            hienthi();
                            break;
                        case 3:
                            timkiemtheoId();
                            break;
                        case 4:
                            timkiemtheoMaker();
                            break;
                        case 5:
                            sapXepPrice();
                            break;
                        case 6:
                            sapXepYear();
                            break;
                        case 7:
                            return;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
        }
    }
}
