using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    abstract partial class Worker
    {
        /// <summary>
        /// This is A Partial Class with all Fields and Constructor Found In A File Called Inheritance_Ploymorphism_2 Under The same Assembly or Namespace
        /// </summary>
       #region Methods and Logic()
        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Name: {Name} \n Age: {Age} \n ID: {Id} \n Salary: {Salary} \n Social Security Number {SSN}");
        }
        public virtual void GetBonus(int bonus)
        {
            Salary += bonus;
            Console.WriteLine("Your Bonus: {0} \nNew Salary: {1}",bonus,Salary);
        }
        public void AllowPromotion(Worker worker) => GivePromotion(worker);
        private void GivePromotion(Worker worker)
        {
            Console.WriteLine($"Congratulation {worker.Name} You Have Been Promoted !!");

            if(worker is Marketer marketer)
            {
                //Console.WriteLine($"You Made {((Marketer)worker).NumberOfSales}");   The Old Code
                Console.WriteLine(value:$"You Made {marketer.NumberOfSales}"); // Simplified as Follows
                Console.WriteLine();
            }
            if(worker is FactoryWorker factoryWorker)
            {
                // Console.WriteLine($"The Stock Options Currently is: {((FactoryWorker)worker).StockOptions}"); This Can Be simplified
                Console.WriteLine(value: $"The Stock Options Currently is: {factoryWorker.StockOptions}");
            }
        }

        /// <summary>
        /// The Private Function Give Promotion can be thus simplified
        /// </summary>
        /// 
        
        public void DisplayWorkerType(Worker worker)
        {
            if(worker == null)
                Console.WriteLine("Worker Not Found");
            else
                switch (worker)
                {
                    case FactoryWorker factoryWorker:
                        Console.WriteLine("You are A {0} in this Organisation",factoryWorker.WorkerType.ToString());
                        Console.WriteLine($"{factoryWorker.Name} is a {factoryWorker.ToString()}");

                        break;
                }
        }
        #endregion
    }

    class FactoryWorker : Worker
    {
        #region Automatic Properties
        public int HourlyRate { get; set; }
        public int StockOptions { get; set; }
        #endregion

        #region Constructors()
        public FactoryWorker(): base() { }
        public FactoryWorker(string name, int age, int id, int salary,int hourlyRate): base(name, age, id, salary,null)
        {
            HourlyRate = hourlyRate;
        }
        #endregion

        #region Methods and Logic
        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Hourly Rate: {HourlyRate}");

        }
        public override  void GetBonus(int bonus)
        {
            Random r = new Random();
             
            StockOptions += r.Next(10);
            Console.WriteLine("Stock Options {0}", StockOptions);
            base.GetBonus(bonus);
        }


        #endregion
    }

    class Marketer : FactoryWorker
    {
        #region Automatic Properties
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
