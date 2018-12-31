using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




/// <summary>
/// Based On Good Practice, It should Be Noted That any Public Function Declared should Recieve or logic from a Private Function.
/// Cause This give Births To The concept of Securrity Concious application.
/// 
/// 
/// 
/// All Right is Reserved, Hand Coded By Emmanuel Israel (Kinga Ojem)
/// With Guidiance From Pragim Technologies(Venkert), Pro C# 7 By Andrew Troelsen & Philip Japikse ( an Apress Textbook).
/// </summary>


namespace CSharpBasics{

    #region Calling & Creating Enums, Changing Data Type etc
        enum Gender : byte{
           MALE = 1,
           fEMALE = 2,
           uNKNOWN
        }
    #endregion

    #region Working With structures, Manipulation etc;
        struct Staff
        {
            int id, level;

            public Staff(int input1, int input2)
            {
                id = input1;
                level = input2;
            }
            public void Display() =>  DisplayValues();
            public void Increment() => IncrementLogic();
        
            private void DisplayValues()
            {
                string value1 = $"Input 1 = {id}";
                string value2 = $"Input 2 = {level}";
                Console.WriteLine(value1);
                Console.WriteLine(value2);
            }
            private void IncrementLogic()
            {
                id++;
                level++;

                Console.WriteLine(id++);
                Console.WriteLine(level++);
            }
            

        }
    #endregion

    class Program
    {
       
        static void Main( string [] args)
       {
            Console.Title = "King Ojem";

            //(string FirstName, int Age, char Sex, bool? Likes) EmployeeDetails = ("emmanuel", 20, 'm', null);

            //string userINput = Console.ReadLine();
            //int userage = int.Parse(Console.ReadLine());
            //var EmployeeDetails = (FirstName: userINput, Age: userage);
            //Console.WriteLine("Your Name is {0}",EmployeeDetails.FirstName);

            //var foo = new  { name1 = "james",name2= "emma" };
            //var boo = (foo.name2);

            //Console.WriteLine(boo.name2);




            //Console.WriteLine("Sending Person Details BY Value");
            //Person james = new Person("tolu", 15);
            //james.DisplayDetails();
            //Console.WriteLine();
            //SendDetails(person:james);
            //james.DisplayDetails();
            //Console.WriteLine();
            //DetailsByRef(person: ref james);
            //james.DisplayDetails();
            //Console.WriteLine();


            //UserInput();
            // ValueAndRefrenceType();
            //DefaultSettings();
            //DefaultDisplay.WelcomeMessage();
            //NewSettings();
            //Student.StudentCall();

            //byte[] enumType = (byte[])Enum.GetValues(typeof(Gender));

            //object[] n =  Enum.GetNames(typeof(Gender));
            //foreach(object y in n)
            //{
            //    Console.WriteLine("The Value Type is {0}", y);
            //}
            //Gender gen = Gender.fEMALE;
            //var j = gen.ToString();
            //Console.WriteLine(j);
            //Console.WriteLine("{0} = {1}", gen.ToString(), (byte)gen);


            //ThisIsNullablePractice thisIsNullablePractice = new ThisIsNullablePractice();
            //int? i = thisIsNullablePractice.GetIntValue();
            //bool? j = thisIsNullablePractice.GetBoolValue();
            //if (i.HasValue)
            //    Console.WriteLine("Value of 'i' is: {0}", i.Value); 
            //else
            //    Console.WriteLine("Value of I is Undefined");
            //if(j != null)
            //    Console.WriteLine("Value of 'J' is: {0}", j.Value);
            //else
            //    Console.WriteLine("Value of J is Undefined");

            //int? m = thisIsNullablePractice.GetIntValue() ?? 56;
            //    Console.WriteLine("Value of 'M' is: {0}", m.Value);

            //string[] names = new string[2] { "peter", "jhon" };
            // Nullable<int> names = new Nullable<int>[2];
            //NUll( null);

           var test = SplitNames("Emmanuel");

            Console.WriteLine(value:test.first);

       }
        static (string first, string middle, string last) SplitNames(string fullName)
        {
            //do what is needed to split the name apart  
            return ("Philip", "F", "Japikse"); 
        }

        //static void SendDetails(Person person)
        //{
        //    person.Age = 34;

        //    person = new Person("Peter", 65);
        //}

        //static void DetailsByRef(ref Person person)
        //{
        //    person.Age = 54;

        //    person = new Person("Emmanuel", person.Age);
        //}

        static void NUll(string[] names)
        {

            Console.WriteLine($"Length is: {names?.Length ?? 0}");

        }

        #region Work in The Calling and Manipulation Of structures(commonly called struct)
        public static void UserInput()
            {
                object input1 = Console.ReadLine();
                object input2 = Console.ReadLine();

                var x = int.TryParse(input1.ToString(), out int k) ? k : input1;
                var j = int.TryParse(input2.ToString(), out int i) ? i : input2;

                if(x  == input1 || j == input2)
                {
                    Console.WriteLine(Warning());
                }
                else
                {
                    Staff staff = new Staff((int)x,(int)j);
                    staff.Display();
                    staff.Increment();
                
                }

                 string Warning()
                 {
                    string Warn = "Invalid INput, Please input A Number";
                    return Warn;
                 }
            }
        #endregion

        #region Learning about Refrence and Value Type; Puting skill in action (Struct, enum Are Value Type, Not in The Head or Base Class System.Object)

        static void ValueAndRefrenceType()
            {
                Staff staff1 = new Staff(20, 50);
                Staff staff2 = staff1;

                staff1.Display();
                Console.WriteLine();
                staff2.Display();
                Console.WriteLine();
                staff1 = new Staff(30, 23);
                staff1.Display();
                Console.WriteLine();
                staff2.Display();
                Console.WriteLine();
                Console.WriteLine("This shows Refrennce Type");


                Employee employee = new Employee("Emmanuel", 30);
                Employee employee2 = employee;

                employee.ShowDetails();
                Console.WriteLine();
                employee2.ShowDetails();
                Console.WriteLine();

                employee = new Employee("james", 400);
                employee.ShowDetails();
                Console.WriteLine( );
                employee2.ShowDetails();

            }
        #endregion

        #region Manipulation Of Console Styles, Color, Name
            public static void DefaultSettings()
            {
                ConsoleColor prev = Console.ForegroundColor;
                ConsoleColor backG = Console.BackgroundColor;


                Console.ForegroundColor = prev;
                Console.BackgroundColor = backG;
            }

            static void NewSettings()
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
        #endregion

    }

    #region The Class Used To Learn abpot ValueType and Refrence Type
        
    class Employee
    {
        string id;
        int level;

        public Employee(string input1, int input2)
        {
            Employee employee = this;
            employee.id = input1;
            employee.level = input2;
        }

        public void ShowDetails() => DetailsToShow();
          

        private void DetailsToShow()
        {
            string value1 = $"Input 1 = {id}";
            string value2 = $"Input 2 = {level}";
            Console.WriteLine(value1);
            Console.WriteLine(value2);
        }
        
    }
    #endregion

    #region Learning To Call Clsss, Using Parameter; Calling array Class; Using Expression body tag (=>)
    class Student
    {
            private string Name { get; set; }
            private Gender Gender { get; set; }

            public static void StudentCall(){
                Student[] student = new Student[3];

                student[0] = Student1();
                DefaultDisplay.WelcomeMessage();

                student[1] = Student2();
                DefaultDisplay.WelcomeMessage();

                student[2] = Student3();

                foreach (Student students in student)
                {
                    Program.DefaultSettings();
                    Console.WriteLine($" Welcome: {students.Name} \n Gender:{students.Gender} ");

                }
            }

            private static Student Student1() => new Student
            {
                Name = Console.ReadLine(),
                Gender = Gender.MALE
            };
            private static Student Student2() => new Student
            {
                Name = Console.ReadLine(),
                Gender = Gender.fEMALE
            
            };
            private static Student Student3() => new Student
            {
                Name = Console.ReadLine(),
                Gender = Gender.uNKNOWN
            };
        }
    
        class DefaultDisplay
        {
            public static void WelcomeMessage(){
            Console.WriteLine("Welcome: Input Your Name And Gender(Remember, 1 = Male & 2 = Female");
            }
            public static string GenderDisplay(Gender e)
            {
                return GenderDisplayCall(e);

            }

            private static string GenderDisplayCall(Gender e)
            {
                switch (e)
                {
                    case Gender.MALE:
                        return "Male";
                    case Gender.fEMALE:
                        return "Female";
                    case Gender.uNKNOWN:
                    default:
                        return "Invalid Character; \n Gender Unknown";
                   
                }
            }
        }
    #endregion



    #region

    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person() { }
        public void DisplayDetails()
        {
            Console.WriteLine($"Person Name = {Name} \n Age = {Age}");
        }

       
    }
    class ThisIsNullablePractice
    {
        int? NumericValue = null;
        bool? BoolValue = true;

        //public ThisIsNullablePractice(int? numericValue, bool? boolValue)
        //{
        //    NumericValue = numericValue;
        //    BoolValue = boolValue;

        //}
        public int? GetIntValue()
        {
            return NumericValue;
        }
        public bool? GetBoolValue()
        {
            return BoolValue;
        }
    } 
    #endregion
}










