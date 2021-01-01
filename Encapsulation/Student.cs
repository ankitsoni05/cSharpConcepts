using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Student
    {

        /*
         * This is autoimplemented properties we do not need to set and get it, it  will automatically create auto impleted private fields.
         * introduced from c# 3.0
         * In encapsulation data fields are hidden from other classes (data-hiding.) they can be accessed only from member function in that class.
         field is read-only if we use only get accessor.
         field is write-only if we use only set accessor.
         */
        public int _id { get; set; } 
        private string _city;
        private string _name;

        #region New way of encapsulation

        /*
         This is new way of performing encapsulations, in older ways we need getter and setter to set and get private fields of class.
             */
        public string name 
        {
            get
            {
                return string.IsNullOrWhiteSpace(_name) ? "No Name" : _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._name = value;
                }
            }
        }
        private int _age;
        public int age
        {
            get
            {
                return this._age;
            }
            set
            {
                if (value >= 18)
                    this._age = value;
                else
                    throw new Exception("not qualified because of age");
            }
        }
        #endregion

        #region Old way of implementing encapsulation (We still use this way in java) (using getter and setter for member validation)
        public void setCity(string CtyName) //setter for validating and setting city
        {
            if (!string.IsNullOrWhiteSpace(CtyName))
            {
                this._city = CtyName;
            }
        }
        public string getCity() //Getter for getting city values
        {
            return string.IsNullOrWhiteSpace(this._city) ? "No city found" : this._city;
        }
        #endregion
    }
}
