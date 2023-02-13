using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapeOOP
{
    class Circle : Figure
    {
        double r;

        public Circle(double r)
        {
            this.R = r;
        }

        public double R { get => r; set => r = value; }

        public override double caculArea()
        {
            if (R > 0)
                return Math.PI * Math.Pow(R, 2);
            else
                return 0;
        }
    }
}
