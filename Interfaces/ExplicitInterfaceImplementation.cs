using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface I1
    {
        void print();
    }
    public interface I2
    {
        void print();
    }
    public class ExplicitInterfaceImplementation : I1, I2
    {
        void I1.print()
        {
            Console.WriteLine("Print method of I1 interface");
        }
        void I2.print()
        {
            Console.WriteLine("Print method of I2 interface");
        }
    }
}
