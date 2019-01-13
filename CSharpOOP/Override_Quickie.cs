using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Override_Quickie
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public static void InitializeCaller() => Caller();

        private static void Caller()
        {
            Override_Quickie override_Quickie = new Override_Quickie();
            override_Quickie.FirstName = "Emmanuel";
            override_Quickie.LastName = "Israel";

            Override_Quickie override_Quickie2 = override_Quickie;

            // Using the double Equals sign in c# stands for refrence equals sign
            // therefore, this checks if two refrence are pointing to te same object on the heap
            // while the Equals sign get the value if its equal
            // but by default, if the refrence is false, then the value type as to be false

            //the following code displays true
            Console.WriteLine(override_Quickie == override_Quickie2);
            Console.WriteLine(override_Quickie.Equals(override_Quickie2));

            // Assuming another refrence is pointing to another objeect on the heap
            Override_Quickie override_Quickie3 = new Override_Quickie();
            override_Quickie3.FirstName = "Emmanuel";
            override_Quickie3.LastName = "Israel";

            //the following code displays false
            Console.WriteLine(override_Quickie == override_Quickie3);
            Console.WriteLine(override_Quickie.GetHashCode());
            Console.WriteLine(override_Quickie3.GetHashCode());

            //since they contain the same value, this is suppose to display true but as a result of no overriden Equals Method, it display false
            Console.WriteLine(override_Quickie.Equals(override_Quickie3));
        }
            ///Now if am to Ovveride this,

        public override bool Equals(object obj)
        {
            //i have to first check if the object refrence is null
            if (obj == null)
            {
                // if the object is null, return fals
                return false;
                //you cannot check if an object or value is equal to null right?
            }
            //i have to check if its of this type
            //that is, i wont want an employee with the same name be equal to a coffee customer right?
            if (!(obj is Override_Quickie))
            {
                // if the object in compa[rison is not of type Override_Quickie, return false
                return false;
            }

            // the logic cannot get to this section if the following logic is wrong
            //since obj is coming from the base class Objects, i have to cast it to this class so it can identify is
            // && means AND also ^ means And
            return this.FirstName == ((Override_Quickie)obj).FirstName && this.LastName == ((Override_Quickie)obj).LastName;
        }
        ///Then there  is anoter thing that must be noted, it is a good practice as you ovveride the Equals, you also ovveride the hashcode

        public override int GetHashCode()
        {
            return this.LastName.GetHashCode() ^ this.FirstName.GetHashCode();
        }
    }
}

