using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    /// <summary>
    /// an Interface By Convention Begins In "I" and is implicitly public and abstarct by default... and an interface can be declared in any file using te keyword interface
    /// </summary>
    interface IPointy
    {
        byte Points { get; }
    }
    interface IDraw
    {
        void Draw3D();
        byte Points { get; }

    }

    //To Begin and Understand The Concept of IEnumeratable
    //An Object cannot be iterated unless it inherits the interface thst ships with the dot net call IEnumerable
    //AND DECLARES A PUBLIC OR EXPLICITY function declared by IEnumerator
    class Garage : IEnumerable
    {
        private Car[] cars = new Car[4];

        public Garage()
        {
            cars[0] = new Car("Rusty", 30);
            cars[1] = new Car("Clunker", 55);
            cars[2] = new Car("Zippy", 30);
            cars[3] = new Car("Fred", 30); 
        }

         //Not Making this public and defining it explicitly, makes the functionality of the interface hidden
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return cars.GetEnumerator();
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {   // Return the array object's IEnumerator.  
            return cars.GetEnumerator();
        }

            public static void IterateItemInGarage()
        {
            Garage garage = new Garage();

            foreach( Car c in garage)
            {
                Console.WriteLine($"{c.brand} is at {c.speed} speed");
            }
            
        }
    }
    class POintsDescription
    {
        public string Name { get; set; }
        public Guid ID { get; set; }

        public POintsDescription()
        {
            Name = "No Name";
            ID = Guid.NewGuid();
        }
    }
    class Points:ICloneable
    {
        public Int32 X{get; set;}
        public System.Int32 Y { get; set; }

        public POintsDescription des = new POintsDescription();

        public Points() { }
        public Points(int _x, int _y,string Name)
        {
            X = _x;
            Y = _y;
            des.Name = Name;
        }
       

        public override string ToString() => $"X = {X}; Y = {Y} \n {des.Name} \n {des.ID}";

        public static void Initalize() => Caller();

        private static void Caller()
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            Console.WriteLine("Cloned p3 and stored new Point in p4");
            Points p3 = new Points(100, 100, "Jane");
            Points p4 = (Points)p3.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            p4.des.Name = "My new Point";
            p4.X = 9;
            Console.WriteLine("\nChanged p4.desc.petName and p4.X");
            Console.WriteLine("After modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            Console.ReadLine();

        }

        //This allows Refrences to have standalone copy of the object type on the heap

       // public object MakeObjectClone => Clone();
       public object Clone()
       {
            //return new Points(this.X,this.Y);
            return this.MemberwiseClone();
       }


    }
}
