using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate bool isStudentPass(student student);
    public class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public int totalmarks { get; set; }

        public static void IsPassed(List<student> students,isStudentPass isStudentPass)
        {
            foreach (student student in students)
            {
                if (isStudentPass(student))
                    Console.WriteLine(student.Name+" is Passed");
                else
                    Console.WriteLine(student.Name+" is Failed");
            }
        }
    }
}
