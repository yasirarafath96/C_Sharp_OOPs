using System;
using System.Security.Principal;

namespace Access_modifiers
{
    /* ACCESS MODIFIER
     * PUBLIC 
     * PRIVATE
     */


    // ENCAPSULATION
    // Define feilds as private 
    // provide getter and setter methods as public 
    public class Person
    {
        private string _pin;

        public void SetPin(string account_pin)
        {
            _pin = account_pin; 
        }
        public string GetPin()
        {
            return _pin;
        } 


    }
    class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.SetPin("jello");
            Console.WriteLine(person.GetPin);

        }
    }
}

/* CAMEL CASE = NameDon   first letter of all word id cap
 * PASCAL CASR = Gamename   only first lette is cap and all are small letter 
 
var guy = new Person();   // instance
            guy.SetName(new DateTime(1993, 1, 1));
            Console.WriteLine(guy);
            Console.ReadLine();
 
 private feilds are declared with _ in the begining */