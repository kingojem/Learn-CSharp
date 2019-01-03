#region Dependencies
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using static System.Console; //this is optional,
using static System.DateTime; // this is optional
#endregion

namespace CSharpOOP
{
    #region Methods That Defines and Or Controls or Establish Employee activities(This is A Partial Class)
    public partial class Employee
    { 
        #region Methods()
        public void IncreaseSalary(float increase)
        {
            Console.WriteLine("Your Salary Increased");
            Salary += increase;
        }
        public void DisplayStatus()
        {
            Console.WriteLine($"{empName} With Employee ID : {empID} \n Current Salary: {empSalary}");
        }
        #endregion


        #region Encapsulation using Accesor and Mutator Method(commented out)
        // Encapspulation using the Accessor and Mutator Methods
        //public string GetName() => empName;
        //public void SetName(string name)
        //{
        //    if (name.Length > 10)
        //        Console.WriteLine("Invalid Name Supplied \n Name Shouldn't Exceed 10 Characters");
        //    else
        //        empName = name;
        //}

        ///<summary>
        ///this Comment uses the traditional Accessor and Mutator Method, Commonly Called Getter and Setter Method.
        ///</summary>
        #endregion
    }
    #endregion

    #region A Partial Class Test and Sample
    public partial class PartialTest
    {
        partial void DisplayMessage()
        {
            Console.WriteLine("A Patial Method must be Decleard before Implementation");
        }
    }
    #endregion

    #region Basic Inheritance(Very weak) And Parial Class Test(for Understanding)
    public class Person : Employee
    {
        public int Age { get; set; } = 1;
        public string Address { get; set; }
        public new  Employee Name { get; set; }  // Using the new Keyword, This is called method hiding

        public Person() { }
        public Person(Employee employee) : this(employee, 0, "") { }
        public Person(Employee employee, int age, string address)
        {
            Name = employee;
            Age = age;
            Address = address;

        }

        static Person()
        {
            Console.WriteLine("Who Are You");
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: {0} \n Age: {1} \n Address: {2}", Name, Age, Address);
        }
    }
    #endregion

}
