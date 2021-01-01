using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    /*
     An abstract class may or may not contains absract methods.
     2. An abstract class cannot be sealed because sealed mean class cannot be inherited, where as abstract means we need to implement it, so abstract
     and seled keywords are opposite to each other.
         */
    public abstract class Student 
    {
        public abstract void print();
    }
    /*
     If an class implements from an abstract class then -> that class must provide implementation for the abstact members, otherwise child class must be 
     marked as abstract class.
         */
    public class StudentChild : Student
    {
        public override void print() //Implementing abstract method, override keyword must be used.
        {
            Console.WriteLine("From  print of abstract implemented method.");
        }
    }
}
