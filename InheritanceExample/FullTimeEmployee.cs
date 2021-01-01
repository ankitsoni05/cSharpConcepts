using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class FullTimeEmployee : Employee
    {
        public bool _IsBaseMSGCall;

        /*
         This is method with same name in base class, so this is called method hiding, because base class contains same name
         as that of base class.
             */
        public new void printFullName() 
        {
            if (this._IsBaseMSGCall)
                base.printFullName(); //This is first way of calling method from parent class even if hidden.
            else
                Console.WriteLine(_firstName + " " + _lastName + " -Full Time");
        }
    }

}
