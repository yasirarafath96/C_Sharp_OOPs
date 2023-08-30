using Methods;
using System;
using System.Runtime.CompilerServices;
using static Method.Program;

namespace Method
{
    class Program
    {
        
        static void Usepoints()
        {
            Point cursor = new Point(10, 20);           // instance/ object for the class and putting values to cursor
            cursor.Move(80, 40);                        // changing values for cursor of method MOVE


            Console.WriteLine("the point is at {0} and {1}", cursor.x, cursor.y);
            cursor.Move(20, 30);
            Console.WriteLine("the point is at {0} and {1}", cursor.x, cursor.y);
        }
        static void Useparams()
        {
            var calculator = new Calculator();        // instance for the calculator.cs
            Console.WriteLine(calculator.Sum(1, 2));                   // BE CAREFUL VARIABLE.METHOD NAME SHOULD BE FOLLWED
            Console.WriteLine(calculator.Sum(1, 2, 3));
            Console.WriteLine(calculator.Sum(1, 2, 3, 4));         //  by using params in method n number of parameters can be passed here
        }

        
        public static void Main(string[] args)
        {
            {
                int number;
                var result = int.TryParse("hello", out number);         // TRY PARSE can be used to return a compile error if the code is wrong
                                                                        // since parse cannot convert the int to string as variable 
                if(result)                                              // it has compile error and we know
                {                                                       // use try+enter to use try throw method for error display
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("compiled failed");
                }


                

            }

            Console.WriteLine();
        }
    }
}
//  NOTE
/* --METHODS--
 * NAME N SIGNATURES 
 * METHOD OVERLOADING
 
 * PARAMS KEYWORD 
 * THIS: KEYWORD 
 * TRY FOR COMPILE ERROR 
 * REF MODIFIER
 * OUT MODIFIER 
 * */