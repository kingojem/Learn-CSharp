using System;
using System.Collections.Generic;

namespace CSharpOOP
{
    /// <summary>
    /// What are Delgates, This are known as type safe function pointer, it points to a function, and when you invoke the delgate the function will be invoked
    /// Type safe Means the signature of the function its is pointing to must Match the ssignature of the delegate, else tere is a compiler error
    /// </summary>

    public delegate void SimpleFunctionDelegate(string value); // this delegate recieves a Parameter string value and on intialization, it is pointed to the method simplefunction


    public class LearnDelegate
    {
        private string name;
        public string Name { get => name; set => name = value; }

        public LearnDelegate(string _name)
        {
            Name = _name;
        }
        public LearnDelegate() { }
        public override string ToString() => $"Name: {Name}";
      
        // Creating a simple function That Takes in a simplle Message
        // i make it static so it can be called directly by the class, so it is seen as a utility function
        public static void Simplefunction( string _message)
        {
            Console.WriteLine(_message);
        }
    }
    
    ///<summary>
    ///I want to talk about the need for delaget in the real world
    ///</summary>
    
    public sealed class Pilots
    {
        //fields
        #region Fields
        private  string marital_status; 
        public int ID { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public bool? Marital_Status
        { get => Marital_Status; set
            {
                if(value == true)
                {
                    marital_status = "Married";
                }else if (value == false)
                {
                    marital_status = "Not Married";
                }
                else
                {
                    marital_status = "Unknown";
                }

            }
        }
        public string MaritalStatus { get => marital_status; }
        #endregion

        //constructors
        #region Constructors
        public Pilots(int _id,string _name, int _experience, bool? _marital_status)
        {
            ID = _id;
            Name = _name;
            Experience = _experience;
            Marital_Status = _marital_status;
        }
        public Pilots() { }
        #endregion

        #region Methods and Logic
        public static void Promoteworker(List<Pilots> pilots)
        {

            ///<summary>
            ///The Problem Here is that i have hard coded the logic
            ///the idea of delegate is to make a single function reuseable; thus delegate are often used by framework developers
            /// </summary>
            try
            {
                if(pilots is List<Pilots>)
                {
                    //Console.WriteLine("List Of Pilots :");
                    foreach (Pilots P in pilots)
                    {
                        
                        //Console.WriteLine(P.Name + "Experience :" + P.Experience);
                        if(P.Experience > 10)
                        {
                            Console.WriteLine($"{P.Name }  You Have Beeen Promoted");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Supplied is Not in The List Of Pilots To be Promoted");

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            
        }

        /// <summary>
        /// This is to note that all delegates have a method called GetInvocationList()
        /// whic contains the name of the Method(type x, type y)
        /// and Target(which tells us the type name of the object)
        /// </summary>
        /// <param name="pilots"></param>
        /// <returns>True or False</returns>

        public delegate bool IsPromotable(Pilots pilots);

        public static void PromotePilots(List<Pilots> pilots,IsPromotable isPromotable)
        {
            try
            {
                if(pilots is List<Pilots>)
                {
                    foreach(Pilots P in pilots)
                    {
                        if (isPromotable(P))
                        {
                            Console.WriteLine($"{P.Name} You Have Beeen Promoted");
                        }
                        else
                        {
                            Console.WriteLine($"{P.Name} You are Not Due For Promotion");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Supplied Name is Not A qualified Member in the Liost Of Pilots To Be Promoted");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }

    /// <summary>
    /// Making An Anonymous Function
    /// Also, We Can Make Use of Anonymous Function when we creating or using Events...
    /// lets go ahead and make a simple wpf form
    /// </summary>

   public sealed class ChairOwners
   {
        public string Name { get; set; } = "";
        public int ID { get; set; } = 0;

        private static void GetList()
        {
            List<ChairOwners> chairOwners = new List<ChairOwners>()
            {
                new ChairOwners{Name = "Emmanuel", ID = 34},
                new ChairOwners{Name= "toluwani",ID=345},
                new ChairOwners{Name = "Emmanueleww", ID = 324},
                new ChairOwners{Name= "toluwa2fgni",ID=34455},

            };
            ChairOwners owners = chairOwners.Find(delegate (ChairOwners chairs) 
            {
                return chairs.ID == 34; 
            });
            Console.WriteLine(owners.ID + "" + owners.Name);
        }

        public static void CallOwners() => GetList();
        
    }
    
}
