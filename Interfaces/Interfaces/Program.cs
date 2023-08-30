using System;
using System.Net.NetworkInformation;
using System.Security.Principal;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin1 = 7722;
            int pin2 = 7733;
            int option1 = 1;
            int option2 = 2;
            int[] option3 = {3, 4, 5, 6, 7, 8, 9, 0};
            int item = 0;
            int current_balance;

            int option21 = 1;
            int option22 = 2;
            int option23 = 3;
            int option24 = 4;

                                                                                                            // instance for the ctor
            Account_detail details1 = new Account_detail("John Doe", "john@example.com", 123456, 1000.00m);
            Account_detail details2 = new Account_detail("hooo", "tom@example.com", 456789, 4000.00m);

            try
            {
                Console.WriteLine("Welcome to the bank of Baroda");
                
                Console.WriteLine("enter ur card - press 1 or account number press - 2");
                int openion = int.Parse(Console.ReadLine());

                if (option1 == openion)
                {
                    Console.WriteLine("enter ur pin");
                    int acc_pin = int.Parse(Console.ReadLine());
                    if (acc_pin == pin1)
                    {

                        Console.WriteLine("Account detail - press 1 \n withdraw - press 2 \n Deposit - press 3 \n Quit");
                        int openion2 = int.Parse(Console.ReadLine());
                        if (openion2 == option21)
                        {
                            Console.WriteLine("welcome to the new interface");
                            Console.WriteLine("Account Details:");
                            Console.WriteLine("Name: " + details1.name);       // Assuming you have a property named "Name" in the Account_detail class
                            Console.WriteLine("Email: " + details1.email);     // Assuming you have a property named "Email" in the Account_detail class
                            Console.WriteLine("password: " + details1.password);
                            Console.WriteLine("Balance: " + details1.balance); // Assuming you have a property named "Balance" in the Account_detail class

                        }
                        else if (openion2 == option22)
                        {
                            Console.WriteLine("Enter amount to withdraw:");
                            decimal amount = decimal.Parse(Console.ReadLine());

                            details1.Withdraw(amount);                            // 


                            
                            
                        }
                        else if (openion2 == option23)
                        {
                            Console.WriteLine("Enter amount to deposit : ");
                            decimal amount = decimal.Parse(Console.ReadLine());

                            details1.Deposit(amount);

                        }
                        else if (openion2 == option24)
                            Console.WriteLine("you have entered an in correct pin PLz try again");
//.............................................................................
                    }
                    else if (acc_pin == pin2)
                    {

                        Console.WriteLine("Account detail - press 1 \n withdraw - press 2 \n Deposit - press 3 \n Quit");
                        int openion2 = int.Parse(Console.ReadLine());
                        if (openion2 == option21)
                        {
                            Console.WriteLine("welcome dog");
                            Console.WriteLine("Account Details:");
                            Console.WriteLine("Name: " + details2.name);       // Assuming you have a property named "Name" in the Account_detail class
                            Console.WriteLine("Email: " + details2.email);     // Assuming you have a property named "Email" in the Account_detail class
                            Console.WriteLine("passwoed: " + details2.password);
                            Console.WriteLine("Balance: " + details2.balance); // Assuming you have a property named "Balance" in the Account_detail class

                        }
                        else if (openion2 == option22)
                        {
                            Console.WriteLine("Enter amount to withdraw:");
                            decimal amount = decimal.Parse(Console.ReadLine());

                            details2.Withdraw(amount);


                            
                        }
                        else if (openion2 == option23)
                        {
                            Console.WriteLine("Enter amount to deposit : ");
                            decimal amount = decimal.Parse(Console.ReadLine());

                            details2.Deposit(amount);

                        }
                        else if (openion2 == option24)
                            Console.WriteLine("you have entered an in correct pin PLz try again");

                    }

                }
                else if (option2 == openion)
                {

                    Console.WriteLine("Enter ur acc number");

                }
                else if (item == openion)
                {
                    foreach (var count in option3)
                    {
                        int i = 0;
                        if (item == openion)
                        {
                            i = item;
                        }
                    }
                }
                

                

            }
			catch (Exception)
			{

                Console.WriteLine("Connection error ");
            }
            Console.ReadLine();
            Console.WriteLine("Press any key to quit");
        }
        
    }
}