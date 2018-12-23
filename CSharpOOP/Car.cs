using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Car
    {
        public string brand;
        public int speed;

        public void DisplayCurrentspeed() => Console.WriteLine("Your Current speed {0}MPH",speed);
        public void SpeedUp(int accelerate) => speed += accelerate;
    }
}
