using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpOOP
{
    //This is a Utility Class, Cause all automobile Must Have

    #region Two Classes That explain the Need For static classes(Utility), Not Properly Encapsulated
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
    #endregion


    #region Understanding The Concept of Inheritance
    class Vehicle
    {
        private  int maxSpeed ;
        private readonly string WARNING;
        private int currentSpeed;

       
            
        public int CurrentSpeed
        {
            get => currentSpeed;
            set
            {
                currentSpeed = value;
                if(currentSpeed > maxSpeed)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    
                    
                    MessageBox.Show(DisplayWarning());
                    Console.WriteLine(DisplayWarning());
                    currentSpeed = maxSpeed;
                }
            }
        }
        public int Maxspeed { get => maxSpeed; } //This is readonly, i could have added thr readonly modifier but i prefer this way..

        public Vehicle(int max)
        {
            this.maxSpeed = max;
            WARNING = "WARNING: Maximum Speed Reached \n Ensure Seat Belts are On";
        }
        public Vehicle()
        {
            this.maxSpeed = 200;
            WARNING = "WARNING: Maximum Speed Reached \n Ensure Seat Belts are On";

        }
        public void DisplaySpeedometer()
        {
            Console.WriteLine($"Max Speed = {Maxspeed}\n Current Speed = {CurrentSpeed} \n Oil Level = {BreakPadOil()}");
        }
        public void SomethingFun()
        {
            Console.WriteLine("Yeah");
        }
        private string DisplayWarning() => WARNING;

        #region Internal Of The Car
        // The Engine of the car is now available to the outside world
        protected Engine Engine = new Engine();
        public int BreakPadOil()
        {
            var breakPadOIL = Engine.BreakPad = 800;
            return Engine.BreakPadLevel(breakPadOIL);

        }

        #endregion
    }

    //this is term a classical inheritance, also knwn as "is a relationship"
    class Ferari : Vehicle
    {
        public Ferari() { }
        public Ferari(int max):base(max) { }
        public new void SomethingFun()
        {
            //string thatsright = "Thats Right";
            base.SomethingFun();
           
        }


    }

    //Now lets say  evry car as a Break Pad or say a letheather seat, it will be very unwise tto say vehiccle is a radio, so it uuses a delegaton model,"has a " relationship

    class Engine
    {
        private int breakPad;
        public int BreakPad { get => breakPad; set => breakPad = value; }
        public int BreakPadLevel(int _breakPadLevel) => BreakPad = _breakPadLevel;
    }
    #endregion



}
