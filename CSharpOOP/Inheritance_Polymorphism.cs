using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Worker
    {
        #region Fields
        private readonly int ssn = 678;
        #endregion
        #region automatic Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; } 
        public int Salary { get; set; }
        public int SSN { get => ssn; }
        #endregion

        #region Constructors()
        public Worker() { }
        public Worker( string name, int age, int id, int salary)
        {
            Name = name;
            Age = age;
            Id = id;
            Salary = salary;
            
        }
        //public Worker(int ssn) { }
        #endregion

        #region Methods and Logic()
        public void DisplayStatus()
        {
            Console.WriteLine($"Name: {Name} \n Age: {Age} \n ID: {Id} \n Salary: {Salary} \n Social Security Number {SSN}");
        }
        public virtual void GetBonus(int bonus)
        {
            Salary += bonus;
            Console.WriteLine("New Salary: {0}",Salary);
        }
        #endregion
    }

    class FactoryWorker : Worker
    {
        #region Automatic Properties
        public int HourlyRate { get; set; }
        #endregion

        #region Constructors()
        public FactoryWorker(): base() { }
        public FactoryWorker(string name, int age, int id, int salary,int hourlyRate): base(name, age, id, salary)
        {
            HourlyRate = hourlyRate;
        }
        #endregion

        #region Methods and Logic
        public new void DisplayStatus()
        {
            Console.WriteLine($"Name: {Name} \n Age: {Age} \n ID: {Id} \n Salary: {Salary} \n Social Security Number: {SSN} \n Hourly Rate: {HourlyRate}");

        }
        
        #endregion
    }

    class Marketer : FactoryWorker
    {
        #region Aultomatic Properties
        public int NumberOfSales { get; set; }
        #endregion
        public Marketer() { }
        public Marketer(string name, int age, int id, int salary, int hourlyRate,int numberOfSales):base(name:name,age:age,id:id,salary:salary,hourlyRate:hourlyRate)
        {
            NumberOfSales = numberOfSales;
        }
        public override void GetBonus(int salesBonus)
        {
            salesBonus = NumberOfSales / 5;
            
            base.GetBonus(salesBonus);
        }

    }
}
