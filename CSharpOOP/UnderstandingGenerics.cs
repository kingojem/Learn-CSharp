using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class UnderstandingGenerics
    {
        //Understanding Generics
        //Generics are Dynamic Containers for storing Data with No fixed amount of size

        //There are several Non Generic with thier Generic Counterparts That Give the same features with better opportunities

       
        #region 1. List
        public static void InitializeListGenerics() => List();

        private static void List()
        {
            List<Car> cars = new List<Car>()
        {
            new Car(){Brand ="Toyota",Speed = 34},
            new Car(){Brand ="Toyotalu",Speed = 340},
            new Car(){Brand ="Toyotalli",Speed = 3467},
            new Car(){Brand ="Toyotally",Speed = 34098},

        };

            //Contains A Property Called Count, As The Name is Pronounced
            Console.WriteLine("The List Contains How Many Cars {0}",cars.Count);
            //The Generic List Extendes the Interface IEnumeratable, IEnumeratable<T>(Where T signify a type)
            foreach(Car C in cars)
            {
                Console.WriteLine(C);
            }
            Console.WriteLine();

            //Add to the List Using Add()
            cars.Add(new Car() { Brand = "Toyotallyulo", Speed = 3498 });
            Console.WriteLine("The List Now Contains How Many Cars {0}", cars.Count);
            foreach (Car C in cars)
            {
                Console.WriteLine(C);
                
            }
            Console.WriteLine();

            //Instead Of Multiple Add, I Can Say Insert(This also allows The desired index to be specified)
            cars.Insert(2, new Car() { Brand = "Toyotallemm", Speed = 498 });
            foreach (Car C in cars)
            {
                Console.WriteLine(C);
            }
            Console.WriteLine();
            //The Elements of the List of Type Person can be copied into an array, This Allows Us to Give or Perform all non Generic action on te List but it is type safe
            Car[] carsList = cars.ToArray();

            foreach (Car cL in carsList)
            {
                Console.WriteLine("The Brand is {0}",cL.Brand);
            }
        }
        #endregion

        #region 2. Stack
        public static void InitializeStackGenerics() => Stack();

        private static void Stack()
        {
            //stack is a data-type iteam That Uses Last In First Out(in Realality, A stack of Plate uses the Last to Be added is the first to be removed from the list)
            //elemenats on a list are poped and pushed in
           
            Stack<Car> cars = new Stack<Car>();
            cars.Push(new Car() { Brand = "Toyotate", Speed = 34 });
            cars.Push(new Car() { Brand = "Toyota", Speed = 34344 });
            cars.Push(new Car() { Brand = "Toyotaqeg", Speed = 34221 });
            cars.Push(new Car() { Brand = "Toyotaff", Speed = 3423 });
            Console.WriteLine(cars.Peek());
            Console.WriteLine(cars.Pop());
            Console.WriteLine(cars.Peek());
            Console.WriteLine(cars.Pop());
            Console.WriteLine(cars.Pop());

            try
            {
                Console.WriteLine(cars.Pop());
                Console.WriteLine(cars.Pop());
                Console.WriteLine(cars.Pop());
                Console.WriteLine(cars.Peek());
            }catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }
        #endregion

        #region 3. Queue
        //queue is a data-type that works with first in first out;
        //We all have seen how a queue can be in realife

        //Lets Create a Reallife instance
        //Somebody is to buy a Coffee
        //And There is a Really Long Queue

            //A Funtion that Model the Fact That Somebody as been attended to by the attendant

        private static void NextCustomer(Somebody somebody)
        {
            Console.WriteLine($"Next Customer Please; {somebody.Name} as been Attended to");
        }
        //Make a queue
        public static void InitializeQueueGenerics() => Queue();
        private static void Queue()
        {
            Queue<Somebody> somebodies = new Queue<Somebody>();
            somebodies.Enqueue(new Somebody { Name = "Emmanuel", LastName = "James" });
            somebodies.Enqueue(new Somebody { Name = "Emmanuella", LastName = "Jamey" });
            somebodies.Enqueue(new Somebody { Name = "Emmanuelll", LastName = "Jamesonvoku" });


            Console.WriteLine("Fiirst in Line is {0}", somebodies.Peek());
            NextCustomer(somebodies.Dequeue());
            NextCustomer(somebodies.Dequeue());
            NextCustomer(somebodies.Dequeue());

            //Check who is First In Line
            //foreach (Somebody s in somebodies)
            //{


            //}

        }

        #endregion

        #region 4. Sorted Set
        //This is Data-Item that return a sorted item, once it is inserted and or removed
        //it calls the GenericInterface IComparer<T> to help Control The sort Logic

        //Creating a sorting Logic
        // Assuming a have a Line and we want the student to line up According to thier age
        // a Music File in an album, we want them to appear sorted to the user in a uique manner

        private class SortLogic : IComparer<Somebody>
        {
            int IComparer<Somebody>.Compare(Somebody x, Somebody y)
            {
                if(x?.Age > y?.Age)
                {
                    return 1;
                }
                if(x?.Age < y?.Age)
                {
                    return -1;
                }
                return 0;
                
            }
        }

        private static void SortedSet()
        {
            SortedSet<Somebody> somebodies = new SortedSet<Somebody>(new SortLogic())
            {
                new Somebody { Name = "Emmanuel", LastName = "James" ,Age = 45},
                new Somebody { Name = "Emmanuella", LastName = "Jamey" ,Age = 450 },
                new Somebody { Name = "Emmanuelll", LastName = "Jamesonvoku" ,Age = 15 }
            };

            foreach(Somebody s in somebodies)
            {
                Console.WriteLine(s);
            }

            somebodies.Add(new Somebody("peter", "hanna", 1));
            somebodies.Add(new Somebody("tolu", "badmus", 23));
            foreach(Somebody j in somebodies){
                Console.Beep();
                Console.WriteLine(j);
            }

        }

        public static void InitaiLizeSortedSetGenerics() => SortedSet();
        #endregion

        #region 5. Dictionary
        //As the name says dictionary
        //unlike a list, u can specify thr key and value
        //thus the IDictionaty<TKey,TValue> where thre key specify any type of data type and Value representing the object

        public static void InitiaLizeDictiobnaryGenerics() => Dictionary();

        private static void Dictionary()
        {
            Dictionary<string, Somebody> pairs = new Dictionary<string, Somebody>()
            {
                { "FirstPerson",new Somebody("peter", "hanna", 1)},
                { "Second Somebody" ,new Somebody("tolu", "badmus", 23)}
            };

            // Intialization of the Object can Point to a refrence of the Dictionary with the Key
            try
            {
                Somebody somebody = pairs["tolu"];
                Console.WriteLine(somebody);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        #endregion
    }
}
