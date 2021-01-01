using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.TeamA
{
    public class Customer
    {
        public string _firstName { get; set; } //State of class (Variables are called states of class or data members of class)
        public string _lastName { get; set; }
        public string _mName { get; set; }
        public Customer() : this("VoidFname", "VoidLname")
        {

        }
        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public Customer(string FName, string MName, string LName)
        {
            this._firstName = FName;
            this._mName = MName;
            this._lastName = LName;
        }
        public void printFullName() //Bevaviour of class (Methods are called behaviours of class )
        {
            if (this._mName == null)
                Console.WriteLine("Full Name {0} {1}", this._firstName, this._lastName);
            else
                Console.WriteLine("Full Name {0} {1} {2}",this._firstName,this._mName,this._lastName);
        }
    }
}
