using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate bool IsPromotable(Employee employee);
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int experience { get; set; }
        public int salary { get; set; }

        public static void PromoteEmployee(List<Employee> employees,IsPromotable isPromotable)
        {
            foreach (Employee employee in employees)
            {
                if (isPromotable(employee))
                {
                    Console.WriteLine(employee.name + " Is promoted");
                }
            }
        }
    }
}
