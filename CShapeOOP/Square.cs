using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapeOOP
{
    class Square : Figure
    {
        double a;

        public Square()
        {
        }

        public Square(double a)
        {
            this.A = a;
        }

        public double A { get => a; set => a = value; }

        public override double caculArea()
        {
            if (this.a > 0)
                return Math.Pow(this.a, 2);
            else
                return 0;
        }
    }
}
