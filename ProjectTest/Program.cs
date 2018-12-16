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

    class Program{
       
       static void Main( string [] args){
            Console.Title = "King Ojem";
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
            Gender gen = Gender.fEMALE;
            var j = gen.ToString();
            Console.WriteLine(j);
            Console.WriteLine("{0} = {1}", gen.ToString(), (byte)gen);
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
            return GEnderDisplayCall(e);

        }

        private static string GEnderDisplayCall(Gender e)
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
   
      

           


   



