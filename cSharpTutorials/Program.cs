using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
using InheritanceExample;
using Polymorphism;
using MethodOverloadingVSMethodHiding;
using Structures;
using Interfaces;
using MultipleClassInheritanceUsingInterfaces;
using D = Delegates;
using Delegates;
using EH= ExceptionHandling;

namespace cSharpTutorials
{
    class Program
    {
        #region Delegate Demo Part
        public static bool isPromoted(D.Employee employee)
        {
            if (employee.experience >= 5)
                return true;
            else
                return false;
        }

        public static bool IsStudentPassed(D.student student)
        {
            if (student.totalmarks >= 100)
                return true;
            else
                return false;
        }
        #endregion

        public static bool isBudjetItem(Electronics electronics)
        {
            if (electronics.DevicePrice <= 1000)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            #region Exception Handling
            EH.ExceptionHandling.printFileContents();
            #endregion

            #region Delegate example 3 Delegates
            //List<Electronics> electronics = new List<Electronics>();
            //electronics.Add(new Electronics { DeviceId = 123456, DeviceName = "MI TV", DevicePrice = 1000 });
            //electronics.Add(new Electronics { DeviceId = 123, DeviceName = "Samsung", DevicePrice = 500 });
            //electronics.Add(new Electronics { DeviceId = 546, DeviceName = "Oppo", DevicePrice = 6000 });
            //electronics.Add(new Electronics { DeviceId = 8989, DeviceName = "VIVO", DevicePrice = 458 });
            //electronics.Add(new Electronics { DeviceId = 453, DeviceName = "Lenovo", DevicePrice = 650 });
            //electronics.Add(new Electronics { DeviceId = 234235, DeviceName = "HCL", DevicePrice = 450 });
            //electronics.Add(new Electronics { DeviceId = 34534545, DeviceName = "HP", DevicePrice = 78999 });
            //electronics.Add(new Electronics { DeviceId = 234567, DeviceName = "Philips", DevicePrice = 6566 });
            //electronics.Add(new Electronics { DeviceId = 965674, DeviceName = "Onida", DevicePrice = 233 });
            //electronics.Add(new Electronics { DeviceId = 56889, DeviceName = "LETV", DevicePrice = 457 });

            //IsBudjetFriendly isBudjetFriendly = new IsBudjetFriendly(isBudjetItem);
            //Electronics.IsBudjetDevice(electronics, isBudjetFriendly);
            #endregion

            #region delegates Demo student
            //List<D.student> students = new List<D.student>();
            //students.Add(new D.student { Id = 100, Name = "Ankit", age = 25, totalmarks = 200 });
            //students.Add(new D.student { Id = 100, Name = "Shubham", age = 25, totalmarks = 25 });
            //students.Add(new D.student { Id = 100, Name = "Yash", age = 25, totalmarks = 75 });
            //students.Add(new D.student { Id = 100, Name = "Ujwal", age = 25, totalmarks = 600 });
            //students.Add(new D.student { Id = 100, Name = "Arnav", age = 25, totalmarks = 450 });
            //students.Add(new D.student { Id = 100, Name = "Rajat", age = 25, totalmarks = 5 });
            //students.Add(new D.student { Id = 100, Name = "Vedant", age = 25, totalmarks = 23 });

            //D.isStudentPass isStudentPass = new D.isStudentPass(IsStudentPassed);
            //D.student.IsPassed(students, isStudentPass);
            #endregion

            #region delagates Demo
            //List<D.Employee> employees = new List<D.Employee>();
            //employees.Add(new D.Employee { id = 100, name = "Ankit", experience = 5, salary = 12000000 });
            //employees.Add(new D.Employee { id = 100, name = "Soni", experience = 3, salary = 54556 });
            //employees.Add(new D.Employee { id = 100, name = "Yash", experience = 7, salary =12340 });
            //employees.Add(new D.Employee { id = 100, name = "Shubham", experience = 1, salary = 55000 });
            //employees.Add(new D.Employee { id = 100, name = "Ujwal", experience = 8, salary = 650000 });

            //D.IsPromotable isPromotable = new D.IsPromotable(Program.isPromoted);


            //D.Employee.PromoteEmployee(employees,isPromotable);
            #endregion

            #region Delegates            
            //D.PrintMsgPointer deleg = new D.PrintMsgPointer(D.DelegateClass.printMsg);
            //deleg("Method invoked using delegate");
            //D.PrintMsgPointer delegName = new D.PrintMsgPointer(D.DelegateClass.WhatIsMyName);
            //delegName("Ankit");
            #endregion

            #region MultipleClassInheritanceUsingInterfaces
            //AB aB = new AB();
            //aB.MathodA();
            //aB.MathodB();
            #endregion

            #region Explicit interface implementation
            //ExplicitInterfaceImplementation explicitInterface = new ExplicitInterfaceImplementation();
            //((I1)explicitInterface).print();  //We need to explicitly specify which method to call using typecasting.
            //((I2)explicitInterface).print();
            #endregion

            #region Interfaces
            //Interfaces.Customer c1 = new Interfaces.Customer();
            //c1.print();

            ///*
            //    we cannot create an insatnce of interface, but a interface reference can point to a derived class object.
            //*/
            //Interfaces.ICustomer1 customer1 = new Interfaces.CustomerImplementation();
            //customer1.print1();

            //Interfaces.ICustomer2 customer2 = new Interfaces.CustomerImplementation();
            //customer2.print2();
            #endregion

            #region Structures
            //Customer c1 = new Customer(101, "Ankit");
            //c1.printCustomerDetails();

            //Customer c2 = new Customer();
            //c2.Id = 102;
            //c2.Name = "Soni";
            //c2.printCustomerDetails();

            ///*
            // * This is a object initializer syntax introuced in c# 3.0 can be used to initialize either a struct or class.
            // */
            //Customer c3 = new Customer
            //{
            //    Id = 103,
            //    Name = "Ankit Soni"
            //};
            //c3.printCustomerDetails();
            #endregion

            //Method overloading VS method hiding --Start

            /*
               Method overriding :- In method overriding a base class reference variable pointing to child class object, will invole the overriden method
               in the child class.

               Method Hiding :- In method hiding a base class reference variable pointing to child class object, will invoke the hidden method in
               base class.
             */
            //baseClass b = new derivedClass();
            //b.Print();

            //baseClass1 b1 = new derivedClass1();
            //b1.Print();
            //Method overloading VS method hiding --End

            //PolyMorphism --Start
            /*
             Polymorphism is nothing but invoking the child class methods using base class reference variable at runtime.
             */

            //List<Shape> shapes = new List<Shape>
            //{
            //    new circle(5),
            //    new square(10),
            //    new rectangle(2,5),
            //    new sphere(5),
            //};

            //foreach (Shape s in shapes)
            //{
            //    s.calculateArea();
            //}

            // this is possible because partTimeEmployee is a specialization on base class, that is because child class has all the capabalities of base class.

            //PolyMorphism --End


            //FullTimeEmployee FTE = new FullTimeEmployee();
            //FTE._firstName = "Fulltime";
            //FTE._lastName = "Employee";
            //FTE._IsBaseMSGCall = false;
            //FTE.printFullName();
            //((Employee)FTE).printFullName(); //This is 2nd way of calling method from parent class even if hidden.


            //Employee FTE2 = new FullTimeEmployee();

            //PartTimeEmployee PTE = new PartTimeEmployee();
            //PTE._firstName = "Parttime";
            //PTE._lastName = "Employee";
            //PTE.printFullName();

            //PATA.Circle c1 = new PATA.Circle(5);
            //Console.WriteLine("Area of circle for Radius {0} is {1}",c1._radius,c1.CalculateArea());

            //PATA.Customer customer = new PATA.Customer("Ankit","Soni");
            //customer.printFullName();
            //PATA.Customer customer1 = new PATA.Customer();
            //customer1.printFullName();
            //PATA.Customer customer2 = new PATA.Customer("Ankit","Hemant","Soni");
            //customer2.printFullName();
            //int[] arr = new int[5];
            //arr[0] = 5;
            //arr[1] = 1;
            //arr[2] = 4;
            //arr[3] = 3;
            //arr[4] = 7;
            //foreach (var a in arr)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadKey();
            //string s = "569z9";
            //int result;
            //Console.WriteLine(int.TryParse(s, out result));
            //Console.WriteLine(result);

            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(float.MaxValue);

            //int i = 10;
            //float s = i;
            //Console.WriteLine(s);

            //int z = (int)s;
            //Console.WriteLine(z);

            //int? a = 20;
            //int finalVal = a ?? 0; //Null coleasing operator.
            //Console.WriteLine(finalVal);
        }
    }
}
