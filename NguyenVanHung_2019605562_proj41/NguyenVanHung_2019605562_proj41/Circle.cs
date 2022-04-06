using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHung_2019605562_proj41
{
    class Circle
    {
        private double bankinh { get; set; }

        public Circle() { }
        public Circle(double bankinh) { this.bankinh = bankinh; }

        public double Area()
        {
            return Math.PI * Math.Pow(bankinh, 2);
        }
        public double Perimater()
        {
            return 2 * bankinh * Math.PI;
        }
    }
}
