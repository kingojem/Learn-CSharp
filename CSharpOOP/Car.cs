using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    //This is a Utility Class, Cause all automobile Must Have

    static class Radio
    {
        enum Radioswitch : int
        {
            ON = 1,
            OFF = 2
        }
        static Radio()
        {
            
        }
        public static void TurnRadioON(bool control)
        {
            if (control == false)
                Console.WriteLine($"Your Radio is Switched {Radioswitch.OFF} ");
            else
                Console.WriteLine($"Your Radio is Switched {Radioswitch.ON} ");

        }
        
    }
    class Car
    {
        public string brand;
        public int speed;

        public void DisplayCurrentspeed() => Console.WriteLine("Your Current speed {0}MPH",speed);
        public void SpeedUp(int accelerate) => speed += accelerate;

        public void TurnRadioON(bool Switch)
        {
            Radio.TurnRadioON(Switch);
        }
    }
    class Motorcycle
    {
        public string brand;
        public int speed;
        public int driverIntensity;


        public Motorcycle() : this("", 0) { Console.WriteLine("THe Default Parameter Was ASSIGNED"); }
        public Motorcycle(string brand) : this(brand, 0) { Console.WriteLine("You Made A NEW BRand BUT DEfault SPEED"); }
        public Motorcycle(int DefaultSpeed) : this("", DefaultSpeed) { }

        public Motorcycle(string brand, int DefaultSpeed)
        {
            this.brand = brand;
            
            
            speed = DefaultSpeed;
            driverIntensity += (speed / 4);
            
        }

       

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }

        public void DisplayMotorCycleInfo() => Console.WriteLine($"The MotorCYcle Brand is {brand}\n Default Speed: {speed} \n Your Intencity {driverIntensity}");
        


    }
}
