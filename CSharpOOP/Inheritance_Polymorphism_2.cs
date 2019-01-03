using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    partial class Worker
    {
        #region Fields
        private readonly int ssn = 678;
        private Worker _workerType;
        
        #endregion
        #region automatic Properties
        public string Name { get; set; }
        public Worker WorkerType
        {
            get => _workerType;
            set
            {
                switch (value)
                {
                    case FactoryWorker factoryWorker:
                        _workerType = value;

                   
                        break;


                }
            }
        }
        public int Age { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }
        public int SSN { get => ssn; }
        #endregion

        #region Constructors()
        public Worker() { }
        public Worker(string name, int age, int id, int salary, Worker worker)
        {
            Name = name;
            Age = age;
            Id = id;
            Salary = salary;
            WorkerType = worker;

        }
        //public Worker(int ssn) { }
        #endregion
    }


    abstract class Shape
    {
        public string PetName { get; set; }
        public  Shape(string name = "No Name")
        {
            PetName = name;
        }
        public abstract void Draw();
        
        //public abstract void Size();
    }
    class Circle: Shape
    {
        public Circle (string name) : base(name) { }
        public override void Draw() => Console.WriteLine($" Drawing {PetName} The Cicle ");
        
    }
    class Hexagon : Shape
    {
        public Hexagon(string name= "No Name") : base(name) { }

        public override void Draw() => Console.WriteLine($" Drawing {PetName} The Hexagon");

        
    }

    class Somebody
    {
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }

        public Somebody(string _name,string _lastname,int _age)
        {
            Name = _name;
            LastName = _lastname;
            Age = _age;
        }
        public Somebody() { }

        public override string ToString()
        {
            return $" First Name : {Name} \n Last Name : {LastName}\n Age : {Age}";
        }

        public override bool Equals(object obj)
        {
            return obj?.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

    }
}
