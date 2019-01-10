using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using static System.Console;  //  THIS dEFINES CONSOLE, GIVES ME THE ABILITY TO CALL METHODS LIKE WRITELINE AND READLINE DIRECTLY, FOR A MORE CLEAN CODEBASE

//Custom Namespace Importation




namespace CSharpOOP
{
    class OOP
    {
        static void Main(string[] args)
        {
            //InitializeCustomException();
            //InitailizeShapes();
            //Garage.IterateItemInGarage();
            Points.Initalize();
            

            #region This is an Intro to Interface and it does not do anyting but make u understand that an interface can ;work on any class in a namespace or assembly
            void InterfaceUnderstanding()
            {
                //Understanding The Concept Of Interface, Interface allow a class or struct to have a behavior, this are highly polymorphic


                ///<summary>
                ///Te Interfaece Iclonable Ships with The Dot Net Framework and Defines a Method Called Clone; all Program Under The dot Net assemblies can Inherit and Model This 
                ///Behavior
                /// </summary>

                OperatingSystem operatingSystem = new OperatingSystem(PlatformID.Unix, new Version());
                SqlConnection sqlConnection = new SqlConnection();
                string Name = "Hello";

                Clone(Name);
                Clone(operatingSystem);
                Clone(sqlConnection);

                 void Clone(ICloneable cloneable)
                 {
                    var theClone = cloneable.Clone();
                    Console.WriteLine("Your Cloned Object is: {0}",theClone.GetType().Name);
                 }



            }
            #endregion





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



        #region Initializing the Inheritance and The Concept Of Multiple Inheritance Using Interfaces
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
            Shape[] shapes = { new Circle("James"), new Hexagon(), new Circle("Peter"), new Hexagon("Tolu"), new ThreeDCircle("James"), new PolyGon() };

            foreach (Shape e in shapes)
            {
                e.Draw();

                if (e is IPointy pointy)
                {
                    Console.WriteLine("The Number Of Points {0}", pointy.Points);
                }
                else
                {
                    Console.WriteLine("This Shape Has No Points");
                }

                if (e is IDraw draw)
                {

                    DrawA3DObject((IDraw)e);

                }
            }

            void DrawA3DObject(IDraw draw)
            {
                Console.WriteLine("This is A 3D Object");
                draw.Draw3D();
            }
        }
        #endregion


        #region UUNderstandig fully The Need For OVerrides

        static void Initiallizesomebody()
        {
            Somebody somebody = new Somebody()
            {
                Name = "Emmanuel",
                Age = 20,
                LastName = "Ojo"
            };
            Console.WriteLine(somebody.ToString());
            Somebody somebody1 = new Somebody("james", "Ojo", 20);
            Console.WriteLine();
            Console.WriteLine(somebody1.ToString());

           WriteLine("Somebody = Somebody1?: {0}", object.Equals(somebody,somebody1));
            WriteLine("Somebody = Somebody1?: {0}", object.ReferenceEquals(somebody, somebody1));


        }
        #endregion


        #region Understanding Delegates
       
        static void InitializeLearnDelegate()
        {
            LearnDelegate learnDelegate = new LearnDelegate
            {
                Name = "Emmanuel",
                
            };
            WriteLine(learnDelegate.Name.ToString());
            string name = Console.ReadLine();

            /// This Delegate Points to a  static function found 
            // in tohe LearnDelegate class Called simple function, this fully explain the initialization 
            //of calling a Delegate
            SimpleFunctionDelegate simpleFunctionDelegate = new SimpleFunctionDelegate(LearnDelegate.Simplefunction);
            simpleFunctionDelegate(name);
            // Delegate Call....  end


        }

        static void InitializePilots()
        {
            #region Create Pilots Object or Instances
            Pilots pilot1 = new Pilots()
            {
                Name = "Emmanuel",
                ID = 564,
                Experience = 11,
                Marital_Status = false

            };
            Pilots pilot2 = new Pilots();
            pilot2.Experience = 6;
            pilot2.Name = "Peter";
            pilot2.Marital_Status = true;
            Pilots pilot3 = new Pilots(23, "Jamiu", 13, null);
            #endregion

            #region Assemble TOtal List Of Pilots
            // Create A LIst Of Pilots

            List<Pilots> P = new List<Pilots>();
            P.Add(pilot1);
            P.Add(pilot2);
            P.Add(pilot3);
            // Pilots.Promoteworker(P); // This Has an Hard Coded Logic and its not flexible, especially if this a framework that assist other developers promote thier workers

            // Initializing My Delegate
            #endregion
            #region Delegate Call, Logic And Function Call (In a Real life Framework, I can ensure this or this would be done by the tird party calling my code)
            Pilots.IsPromotable isPromotable = new Pilots.IsPromotable(PromoteWorker);

            //This is Now The User Utilized Function That Ensures the Kind Of lOgic That is Needed for Thier bussiness

            bool PromoteWorker(Pilots pilots)
            {
                //The Logic

                if(pilots.Experience >= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                
            }

            Pilots.PromotePilots(P, isPromotable);

            #endregion

            //Function Call

        }

        #endregion

        #region Understanding Exception Handling

        static void InitializeException_Handling()
        {
            Console.WriteLine("Please Input Your Name");
            var Input = Console.ReadLine();
            Console.WriteLine("Please Input Your Age");
            var Input1 = int.TryParse(Console.ReadLine(), out int j) ;
            //Console.WriteLine(" Name = {0}", Input);

            Exception_Handling exception_Handling = new Exception_Handling();
            #region This Explains The Concept of Inner Exception
            try
            {
                try
                {
                    exception_Handling.Name = Input;
                    exception_Handling.Age = j;

                }
                catch (Exception e)
                {
                    string path = @"C:\Users\King Ojem\source\repos\ProjectTest\CSharpOOP\Log.txt";
                    if (File.Exists(path))
                    {
                        StreamWriter streamWriter = new StreamWriter(path);

                        streamWriter.Write($"Type Of Error: {e.GetType().Name} ; ");
                        streamWriter.Write($"Error Message : {e.Message} ; ");
                        foreach (DictionaryEntry de in e.Data)
                        {
                            streamWriter.Write($"Time : {de.Value} ; ");
                        }

                        streamWriter.Write($"Get Help : {e.HelpLink} ; ");
                        streamWriter.Close();

                        Console.WriteLine("There Was an Error \n Please Try Again");
                    }
                    else
                    {
                        throw new FileNotFoundException(Path.GetFileName(path) + @"Located  @ C:\Users\King Ojem\source\repos\ProjectTest\CSharpOOP\ " + " Not Found!!", e);

                    }
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Error ! : {0}", ex.InnerException.Message);
                Console.WriteLine("Error Log Write Failed : {0}",ex.InnerException.Message);
            }

            #endregion


        }

        static void InitializeCustomException()
        {
            throw new MyCustomException();
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
        
        
        public static void PrintTime() =>WriteLine(DateTime.Now.ToShortTimeString());
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
