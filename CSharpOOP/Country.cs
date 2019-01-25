using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Country
    {
        /// <summary>
        /// This is a Small Console Program that allows the user input a country currency code and it displapys the counjtry
        /// its capital and the currency it uses
        /// to store the large number of item of generic size, a dictionary is used to enhance performance
        /// </summary>
        public string Name { get; set; } = "";
        public string Capital { get; set; } = "";
        public string Code { get; set; } = "";
        public string Currency { get; set; } = "";
        #region The Introductory Message
        public static void Lookup( bool status = false )
        {
            // Lets Create a Lists Of countrys
            // when using Lookup you are adviced to use dictionary becase using
            //list will require a function find
            // whic will go thru the who list and may slow down performance if its a long list

            //using dictionary
            string userInput1;
            do
            {
                Console.WriteLine("Please Enter The Country Currency You Intend To Find");
                userInput1 = Console.ReadLine().ToUpper();
                CreateDictionary(userInput1);
            } while (status == true);
            #endregion



        }
        #region Creating a dictionary  of countries 
        private static void CreateDictionary( string outsideInput)
        {
            Country country1 = new Country
            {
                Name = "United States of America",
                Capital = "Washithon D.C",
                Code = "USD",
                Currency= "United States Dollars"
            };
            Country country2 = new Country
            {
                Name = "Nigeria",
                Capital = "Abuja",
                Code = "NGN",
                Currency = "Nigerian Naira"

            };
            Country country3 = new Country
            {
                Name = "India",
                Capital = "Mumbia",
                Code = "INR",
                Currency = "Indian Rupees"

            };
            Country country4 = new Country
            {
                Name = "Ghana",
                Capital = "Accra",
                Code = "GHC",
                Currency= "Ghana Cedies"

            };

            Dictionary<string, Country> countrys = new Dictionary<string, Country>();
            countrys.Add(country1.Code, country1);
            countrys.Add(country2.Code, country2);
            countrys.Add(country3.Code, country3);
            countrys.Add(country4.Code, country4);

            #region Validate User Input from The Dictionary of Countries
            
            void Validate(string inp)
            {
                Country theCode = countrys.ContainsKey(inp) ? countrys[inp] : null;
                
                if(theCode == null)
                {
                    Console.WriteLine("Please Enter A Valid Currency Code Found in the List");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Name: {theCode.Name}\n Capital: {theCode.Capital}\n Code: {theCode.Code}\n Currency: {theCode.Currency}");
                    Console.WriteLine();
                }
                
            }

            string Continue()
            {
                string userInput = string.Empty;
                do
                {
                    Console.WriteLine("Do You Want to Continue?  -- YES or NO");
                    userInput = Console.ReadLine().ToUpper();
                   
                } while (userInput != "YES" && userInput != "NO");
                return userInput;
            }
            #endregion

           Validate(outsideInput);
           if(Continue() == "YES")
           {
                Lookup(true);
           }
            

        }
        #endregion
    }
}
