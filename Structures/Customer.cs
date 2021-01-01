using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public struct Customer
    {
        /*
         Difference between classes and structures :- https://www.geeksforgeeks.org/difference-between-class-and-structure-in-c-sharp/
              */

        private int _id;
        private string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public Customer(int identity,string cName)
        {
            this._id = identity;
            this._name = cName;
        }

        public void printCustomerDetails()
        {
            Console.WriteLine("Customer id is {0} and customer name is {1}",this._id,this._name);
        }
    }
}
