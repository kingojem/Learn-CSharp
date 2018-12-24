using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;  //  THIS dEFINES CONSOLE, GIVES ME THE ABILITY TO CALL METHODS LIKE WRITELINE AND READLINE DIRECTLY, FOR A MORE CLEAN CODEBASE
using static System.DateTime;


namespace CSharpOOP
{
    class OOP
    {
        static void Main(string[] args)
        {
            InitializeStaticClass();
            
        }
        static void InitializeCar()
        {
            Car car = new Car();
            car.brand = "Toyota";
            Console.Title = car.brand;
            car.speed = 10;
            car.DisplayCurrentspeed();

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
        static void InitializeSavingsAccount()
        {
            SavingsAccount savingsAccount = new SavingsAccount(4322.33);
            Console.WriteLine("Interest ADDition To this is : {0}",SavingsAccount.GetInterestAcquired());
            //SavingsAccount.SetIntrestAcquired(0.454);
            SavingsAccount savingsAccount1 = new SavingsAccount(678977.4555);
            Console.WriteLine("Interest ADDition To this is : {0}", SavingsAccount.GetInterestAcquired());
        }
        static void InitializeStaticClass()
        {
            StaticUndestanding.name = "Emmanuel";
            StaticUndestanding.PrintTime();
            StaticUndestanding.PrintDate();
            WriteLine(StaticUndestanding.PrintName() +"\n" );
        }
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
    #endregion
}
