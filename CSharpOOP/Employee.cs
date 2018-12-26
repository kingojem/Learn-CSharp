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
    class Employee { 


        #region Fields
        private string empName ;
        private int empID;
        private float empSalary;
        #endregion

        #region Properties
        public string Name
        { get => empName;
            set
            {
                if(value.Length > 10)
                    Console.WriteLine("Invalid Name \n Name Must Not Exceed 10 Characters");
                empName = value;
            }
        }
        public int ID { get => empID; set=>empID = value; }
        public float Salary { get=>empSalary; set=> empSalary = value; }
        #endregion
        public Employee() { }
        public Employee(string empName) : this(empName, 0, 0f) { }
        public Employee(int empID) : this("", empID, 0f) { }
        public Employee(string empName , int empID, float empSalary)
        {
            Name= empName;
            Salary = empSalary;
            ID = empID;
        }

        public void IncreaseSalary(float increase)
        {
            Console.WriteLine("Your Salary Increased");
            Salary += increase;
        }
        public void DisplayStatus()
        {
            Console.WriteLine($"{empName} With Employee ID : {empID} \n Current Salary: {empSalary}");
        }

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
    }

   
}
