using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTest{
    enum Gender : byte{
       MALE = 1,
       fEMALE = 2,
       uNKNOWN
    }

    struct Staff
    {
        int id, level;

        public Staff(int input1, int input2)
        {
            id = input1;
            level = input2;

        }
        public void Display()
        {
            string value1 = $"Input 1 = {id}";
            string value2 = $"Input 2 = {level}";
            Console.WriteLine(value1);
            Console.WriteLine(value2);
        }

        public void incre()
        {
            id++;
            level++;

            Console.WriteLine(id++);
            Console.WriteLine(level++);

        }

    }

    class Program{
       
       static void Main( string [] args){
            Console.Title = "King Ojem";
            UserInput();
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
        }

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
                staff.incre();
                
            }

             string Warning()
             {
                string Warn = "Invalid INput, Please input A Number";
                return Warn;
             }
        }
        
        public static void DefaultSettings(){
            ConsoleColor prev = Console.ForegroundColor;
            ConsoleColor backG = Console.BackgroundColor;


            Console.ForegroundColor = prev;
            Console.BackgroundColor = backG;
       }
        static void NewSettings(){
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        
    }

    class Student{
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

    class DefaultDisplay{
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
    
}
   
      

           


   



