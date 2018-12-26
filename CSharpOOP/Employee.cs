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

        public Employee() { }
        public Employee(string empName , int empID, float empSalary)
        {
            Employee employee = this;
            employee.empName = empName;
            employee.empSalary = empSalary;
            employee.empID = empID;
        }

        public void IncreaseSalary(float increase)
        {
            Console.WriteLine("Your Salary Increased");
            empSalary += increase;
        }
        public void DisplayStatus()
        {
            Console.WriteLine($"{empName} With Employee ID : {empID} \n Current Salary: {empSalary}");
        }

        // Encapspulation using the Accessor and Mutator Methods
       
        public string GetName() => empName;
        public void SetName(string name)
        {
            if (name.Length > 10)
                Console.WriteLine("Invalid Name Supplied \n Name Shouldn't Exceed 10 Characters");
            else
                empName = name;
        }
    }
}
