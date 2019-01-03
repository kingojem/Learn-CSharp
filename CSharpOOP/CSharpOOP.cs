using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;  //  THIS dEFINES CONSOLE, GIVES ME THE ABILITY TO CALL METHODS LIKE WRITELINE AND READLINE DIRECTLY, FOR A MORE CLEAN CODEBASE
using static System.DateTime;


namespace CSharpOOP
{
    class OOP
    {
        static void Main(string[] args)
        {

           Console.ReadLine();
        }
        #region This is the INItialization of the external Employee File(Including Employee and Person Class)
        static void InitializeEmployee()
        {
            Employee employee = new Employee("Emmanuel",2345,765f);
            employee.DisplayStatus();
            employee.IncreaseSalary(1000);
            employee.DisplayStatus();
            employee.Name = "james";
            employee.Salary = 45567;
            employee.DisplayStatus();

            //employee.SetName()
        }

        static void InitializePerson() 
        {
            Person person = new Person();
            person.Name = new Employee("Emmanuel");
            person.Name.DisplayStatus();
            person.PrintDetails();


        }
        #endregion

        #region This is the INItialization of the external Car File (Including The Car and Motorcycle Class)
        static void InitializeCar()
        {
            Car car = new Car();
            car.brand = "Toyota";
            Console.Title = car.brand;
            car.speed = 10;
            car.DisplayCurrentspeed();
            car.TurnRadioON(true);

            for (int i = 0; i < 20; i++)
            {
                car.SpeedUp(5);
                car.DisplayCurrentspeed();
                if (car.speed > 65)
                {
                    Console.WriteLine("Moving Too Fast! \n Slow Down");
                    break;

                }
            }
        }
       
        static void InitializeMotorCycle()
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.DisplayMotorCycleInfo();
            motorcycle.PopAWheely();
        }
        #endregion

        #region  Understanding The Concept OF STAtic Data(Initialization)
        static void InitializeSavingsAccount()
        {
            SavingsAccount savingsAccount = new SavingsAccount(4322.33);
            Console.WriteLine("Interest ADDition To this is : {0}",SavingsAccount.GetInterestAcquired());
            //SavingsAccount.SetIntrestAcquired(0.454);
            SavingsAccount savingsAccount1 = new SavingsAccount(678977.4555);
            Console.WriteLine("Interest ADDition To this is : {0}", SavingsAccount.GetInterestAcquired());
        }
        static void InitializeStandardSavingsAccount()
        {
            StandardSavingsAccount standardSavingsAccount = new StandardSavingsAccount(3456.976);
            Console.WriteLine("Interest ADDition To this is : {0}", StandardSavingsAccount.InterestRate);

            StandardSavingsAccount standardSavingsAccount1 = new StandardSavingsAccount(64324.34);
            Console.WriteLine("Interest ADDition To this is : {0}", StandardSavingsAccount.InterestRate);

        }
        #endregion

        #region This Initialize The static class, also know as utility class, calls static data fields AND methods
        static void InitializeStaticClass()
        {
            StaticUndestanding.name = "Emmanuel";
            StaticUndestanding.PrintTime();
            StaticUndestanding.PrintDate();
            WriteLine(StaticUndestanding.PrintName() +"\n" );
        }
        #endregion



        #region Initializing the Inheritance
        static void InitializeVehicle()
        {
            Vehicle vehicle = new Vehicle
            {
                CurrentSpeed = 45,
            };
            
            vehicle.DisplaySpeedometer();
            Console.WriteLine();

            Ferari ferari = new Ferari()
            {
                CurrentSpeed = 560,
                
            };
            ferari.DisplaySpeedometer();
            ferari.BreakPadOil();
        }

        static void InitializeWorker()
        {
            
            FactoryWorker factoryworker = new FactoryWorker()
            {
                Age = 23,
                Salary = 10_000,
                Name = "Shawn Mendes",
                HourlyRate = 200,
                Id = 23674,
                
                

            };
            factoryworker.WorkerType = factoryworker;
            factoryworker.DisplayStatus();
            factoryworker.GetBonus(3000);
            //factoryworker.AllowPromotion(factoryworker);
            factoryworker.DisplayWorkerType(factoryworker);

            
            
            
            //Marketer marketer = new Marketer
            //{
            //    Name = "jAMES dADA",
            //    NumberOfSales = 345,
            //    Age = 34,
            //};
            //marketer.DisplayStatus();
            //marketer.GetBonus(3432);
            
        }
        static void InitailizeShapes()
        {
            Shape[] shapes = { new Circle("James"), new Hexagon(), new Circle("Peter"), new Hexagon("Tolu") };
            
            foreach( Shape e in shapes)
            {
                e.Draw();
            }
        }
        #endregion


        #region UUNderstandig fully The Need For OVerrides

        static void Initiallizesomeboody()
        {
            Somebody somebody = new Somebody()
            {
                Name = "Emmanuel",
                Age = 20,
                LastName = "Ojo"
            };
            Console.WriteLine(somebody.ToString());

        }
        #endregion

    }
    #region Understanding The Concept OF STAtic Data,MEthods etc.. ; Making A Bank Savings Model
    class SavingsAccount
    {
        
        public double amountSavedByUser;

        //every 6 Months, Interest acquired BY Customer 
        public static double savingsInterestAcquired;
        // public static double savingsInterestAcquired = 087; DOING THIS IS QUITE OKAY


        public SavingsAccount(double balance)
        {
            amountSavedByUser = balance;
            ///savingsInterestAcquired = 0.445; DOING THIS WILL MAKE THE DATA ITEM RESET AT EVERY CALL, WHICH IS NOT THE GOAL TO BE ACHIEVE
            //

            Console.WriteLine($"Your Balance: {amountSavedByUser}");

        }
        static SavingsAccount() // A STATIC CONSTRUCTOR IS VERY HELPFUL IF YOU WANT TO DEFINE A STATIC DATATYPE PROPERLY, 
                                //ESPECIALLY WHEN THE DATA COMES FROM A LINK OR FILE OR DATABASE
        {
            //default interest
            Console.WriteLine("In static ctor!");
            savingsInterestAcquired = 0.445;
        }
        //static fields can be changed and Manipulated by static Methods :- Defining A Get And Set Method

        public static void SetIntrestAcquired(double interest) => savingsInterestAcquired = interest;
        public static double GetInterestAcquired() => savingsInterestAcquired;


    }

    ///<summary>
    ///Creating A Class Marked As Static is more or less for utility, it cant be called via instances, and all fields and method must be tagged 
    ///or marked as static
    ///</summary>

    static class StaticUndestanding
    {
        public static string name;
        
        
        public static void PrintTime() =>WriteLine(Now.ToShortTimeString());
        public static string PrintName() => name;
        public static void PrintDate() => WriteLine();


       
        
    }


    class StandardSavingsAccount
    {
        private double amountSavedByUser;
        private static double currentInterest;
        public double balance { get => amountSavedByUser ; set => amountSavedByUser = value; }

        public StandardSavingsAccount(double balance)
        {
            this.balance = balance;
            Console.WriteLine($"Your Balance: {this.balance}");

        }
        static StandardSavingsAccount()
        {
            //Console.WriteLine("The Default Interest Rate is");
            currentInterest = 0.654;
        }
        public static double InterestRate
        {
            get => currentInterest;
            set => currentInterest = value;
        }
    }
    #endregion

    



}
