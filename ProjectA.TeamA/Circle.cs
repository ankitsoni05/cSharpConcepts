using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.TeamA
{
    public class Circle
    {
        public static float _PI; //By converting this member to static we will be using single static member for any number of instances rather than repeatating for multiple instances/objects, this will going to save space
        public float _radius { get; set; } //This is instance member of class.

        //Class can have static member or instance member.

        static Circle() //Static ctor is used to initialize static member of class.
        {
            Circle._PI = 3.141F;
        }
        public Circle(float Radius)
        {
            this._radius = Radius;
        }
        public float CalculateArea()
        {
            return Circle._PI * this._radius * this._radius;
        }
    }
}
