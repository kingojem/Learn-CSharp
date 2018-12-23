using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class OOP
    {
        static void Main(string[] args)
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
                if(car.speed > 65)
                {
                    Console.WriteLine("Moving Too Fast! \n Slow Down");
                    break;
                    
                }
            }

        }
    }
}
