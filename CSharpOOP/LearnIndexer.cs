using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    /// <summary>
    /// This is to introduce me into the concept of indexers
    /// </summary>
    public class LearnIndexer :IEnumerable
    {
        //The Need For this is quite redundant as the generic feature gives me this out of the box
        private ArrayList arrayList = new ArrayList();
       public Country this[int index]
       {
            get => (Country)arrayList[index];
            set => arrayList.Insert(index, value);
       }
       //but doing this allows it to integrate well into the fabrics of the dot net base class

            //calling a method placed on country
        public static void Indexer()
        {
            LearnIndexer learnIndexer = new LearnIndexer();
            learnIndexer[0] = new Country { Name = "Emmanuel", Capital = "Kingojem" };
            learnIndexer[1] = new Country { Name = "james", Capital = "badmaus" };

            for(int i = 0; i< learnIndexer.arrayList.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", learnIndexer[i].Name, learnIndexer[i].Capital);
                Console.WriteLine("Age: {0}", learnIndexer[i].Code);
                Console.WriteLine();
            }
        }
        ///<summary>
        ///Also, i can achieve this using the string index,  instead of using an array as seen above, i will be using a dictionary, having that it allows for key value pairing
        /// </summary>

        private Dictionary<string, Country> keyValuePairs = new Dictionary<string, Country>();
        #region Thid id overloading indexer
        public Country this[string key]
        {
            get => (Country)keyValuePairs[key]; // i really dont know why cast is redundant here... but based on my learning i do know i need a cast, i maybe wrong tho'
            set => keyValuePairs[key] = value;
        }
        //if am to clear the list
        public void ClearList() => keyValuePairs.Clear();
        public int Count() => keyValuePairs.Count;

        IEnumerator IEnumerable.GetEnumerator() => keyValuePairs.GetEnumerator();
        #endregion
        public static void Index()
        {
            LearnIndexer learnIndexer = new LearnIndexer();
            learnIndexer["Ojem"] = new Country { Name = "Emmanuel" };
            learnIndexer["kaid"] = new Country { Name = "Kolawole" };

            Country country = learnIndexer["Ojem"];

            Console.WriteLine(country.ToString());
            Console.ReadLine();
        }

        
        

    }

    public class LearnOverloading
    {
        public int X { get; set; }
        public int Y { get; set; }

        public LearnOverloading(int a, int b)
        {
            X = a; Y = b;
        }
        public override string ToString()
        {
            return $"{this.X} & {this.Y}";
        }

        // to allow this classs responds properly to intrisic type operatior, a static keyword and operator function  must be uses like so:

        public static LearnOverloading operator + (LearnOverloading x, LearnOverloading y)
        {
            return new LearnOverloading(x.X + x.Y, y.X + y.Y); // this allows the class to overload binary types like the (+) opperator
        }
        //similarly, this is also done for any binary and unary operator i think
        public static LearnOverloading operator - (LearnOverloading x, LearnOverloading y) => new LearnOverloading(x.X - x.Y, y.X - y.Y); // this allows the class to overload binary types like the (+) opperator
       
    }
}
