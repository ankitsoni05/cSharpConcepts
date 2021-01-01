using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClassInheritanceUsingInterfaces
{
    interface IA
    {
        void MathodA();
    }
    class A : IA
    {
        public void MathodA()
        {
            Console.WriteLine("A");
        }
    }
    interface IB
    {
        void MathodB();
    }
    class B : IB
    {
        public void MathodB()
        {
            Console.WriteLine("B");
        }
    }
    public class AB : IA,IB
    {
        A a = new A();
        B b = new B();

        public void MathodA()
        {
            a.MathodA();
        }

        public void MathodB()
        {
            b.MathodB();
        }
    }
}
