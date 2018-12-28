using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public  partial class Employee
    {
        #region Fields
        private string empName;
        private int empID;
        private float empSalary;
        #endregion

        #region Properties
        public string Name
        {
            get => empName;
            set
            {
                if (value.Length > 10)
                    Console.WriteLine("Invalid Name \n Name Must Not Exceed 10 Characters");
                empName = value;
            }
        }
        public int ID { get => empID; set => empID = value; }
        public float Salary { get => empSalary; set => empSalary = value; }
        #endregion

        #region Constructors
        public Employee() { }
        public Employee(string empName) : this(empName, 0, 0f) { }
        public Employee(int empID) : this("", empID, 0f) { }
        public Employee(string empName, int empID, float empSalary)
        {
            Name = empName;
            Salary = empSalary;
            ID = empID;
        }
        #endregion

    }

    public partial class PartialTest 
    {
        partial void DisplayMessage();
        public static void Display()
        {
            PartialTest partial = new PartialTest();
            partial.DisplayMessage();
        }
    }

}
