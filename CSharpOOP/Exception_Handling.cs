using System;
using System.IO;
using System.Runtime.Serialization;


namespace CSharpOOP
{

    #region Simple Exception Throwing
    class Exception_Handling
    {
        #region Fields
        private int _age;
        private string _name;
        #endregion

        #region Properties And Logic(Exceptions)
        public string Name
        {
            get => _name ;
            set
            {

                ///<summary>
                ///This Can Be Classifed as Exception Abuse
                /// </summary>
                
                if(value.Equals(""))
                {
                    throw new ArgumentException("Input Your Name To Continue");
                }
                else if(value.Length > 5)
                {
                    OverflowException exception = new OverflowException("Textrix Message : User specified Input Exceed Limit !!")
                    {
                        HelpLink = "https://google.com/search?q=Textrix+Message+:+User+specified+input+exceed+limit",

                    };
                    exception.Data.Add("Time Of Error :", $"{DateTime.Now}");
                    //exception.Data.Add("Cause", "Invalid Input Length");
                    throw exception;
                }
                else
                {
                    _name = value;
                }

            }
        } 
        public int Age
        {
            get => _age;
            set
            {
                if( value < 13)
                {
                    throw new ArgumentException($"Under Age Are Not Allowed On The Platform \n Currentt age {value}");
                }
                else if(value <= 0 || value > 35)
                {
                    OverflowException exception = new OverflowException($"{Name.ToUpper()} Kindly Input A Valid Age")
                    {
                        HelpLink = "https://google.com/search?q=Textrix+Message+:+User+specified+input+exceed+limit",

                    };
                    exception.Data.Add("Time Of Error :", $"{DateTime.Now}");
                    //exception.Data.Add("Cause", "Invalid Input Length");
                    throw exception;
                }
                else
                {
                    _age = value;

                }
            }
        }
        #endregion

        #region Constructors
        public Exception_Handling(string _name = "",int _age = 0)
        {
            Name = _name;
            Age = _age;
        }
        public Exception_Handling() { }
        #endregion


    }
    #endregion

    #region Custom Exception
    // This Allows The application to be broken down into packets to be sent over a network... that is, this allows application 1 to be able to use the
    [Serializable]
    //Resources Provided By The application 2
    //To Allow This Possible; The Namespace System.Runtime.Serializable need to be invoked.
    public class MyCustomException : Exception
    {
        //Constructor Chaining
        public MyCustomException() : base() { }
        public MyCustomException(string message) : base (message) { }
        public MyCustomException (string message, Exception innerException) : base (message,innerException) { }
        public MyCustomException (SerializationInfo info, StreamingContext context) : base(info, context) { }


        
    }
    #endregion
}
