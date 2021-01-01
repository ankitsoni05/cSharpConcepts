using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shape
    {
        public static double _PI = Math.PI;
        public double _x;
        public double _y;
        public Shape(double x, double y)
        {
            this._x = x;
            this._y = y;
        }
        public virtual void calculateArea()
        {
            Console.WriteLine("Area from base class = {0}", (this._x * this._y));
        }
    }
    public class circle : Shape
    {
        public circle(double r) : base(r, 0)
        {

        }
        public override void calculateArea()
        {
            Console.WriteLine("Area of circle is :- {0}", (_PI * _x * _x));
        }
    }
    public class square : Shape
    {
        public square(double s) : base(s, 0)
        {

        }
        public override void calculateArea()
        {
            Console.WriteLine("Area of square is :- {0}", (_x * _x));
        }
    }
    public class rectangle : Shape
    {
        public rectangle(double l, double b) : base(l, b)
        {

        }
        public override void calculateArea()
        {
            Console.WriteLine("Area of rectangle is :- {0}", (_x * _y));
        }
    }
    public class sphere : Shape
    {
        public sphere(double r) : base(r, 0)
        {

        }
        public override void calculateArea()
        {
            Console.WriteLine("Area of Sphere is :- {0}", (4 * _PI * _x * _x));
        }
    }
}
