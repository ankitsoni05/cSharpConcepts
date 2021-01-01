using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Employee
    {
        public string _firstName;
        public string _lastName;

        public void printFullName()
        {
            Console.WriteLine(this._firstName +" "+ this._lastName);
        }
    }
}