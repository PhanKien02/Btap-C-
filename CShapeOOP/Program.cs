using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            Square square = new Square(a);
            Circle circle = new Circle(r);
            Console.WriteLine("Dien tich hinh vuong: {0}",square.caculArea());
            Console.WriteLine("Dien tich hinh tron: {0}", circle.caculArea());
            Console.ReadKey();
        }
    }
}
