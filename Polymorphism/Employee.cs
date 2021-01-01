using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        public string _firstName = "FN";
        public string _lasttName = "LN";

        public void printFullName()
        {
            Console.WriteLine("Name :- {0} {1}",this._firstName,this._lasttName);
        }
    }

    public class partTimeEmployee : Employee
    {

    }
    public class fullTimeEmployee : Employee
    {

    }
    public class temporaryEmployee : Employee
    {

    }
}
