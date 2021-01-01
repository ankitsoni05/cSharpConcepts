using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomer
    {
        //int id; interfaces cannot contains fields.
        void print(); //Interface members are public by default.
    }

    public class Customer : ICustomer
    {
        public void print()
        {
            Console.WriteLine("Hello Interfaces");
        }
    }

    public interface IMultInterface1
    {
        void printI1();
    }
    public interface IMultInterface2
    {
        void printI2();
    }

    /*
     A class cannot inherit from multiple classes at the same time, but a class can inherit from multiple interfaces at the same time.
         */
    public class MultipleInterInheritance : IMultInterface1, IMultInterface2
    {
        public void printI1()
        {
            Console.WriteLine("From Interface 1");
        }

        public void printI2()
        {
            Console.WriteLine("From Interface 2");
        }
    }

    #region
    /*
     If a class implements from an interface and that interface is inheriting from other interface then that class must provide implementation for
     all the methods in that inheritance chain otherwise we will get compilation error.
         */

    /*
     we cannot create an insatnce of interface, but a interface reference can point to a derived class object.
         */
    public interface ICustomer1
    {
        void print1();
    }
    public interface ICustomer2 :ICustomer1
    {
        void print2();
    }
    public class CustomerImplementation : ICustomer2
    {
        public void print1()
        {
            throw new NotImplementedException();
        }

        public void print2()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
