namespace Interface
{
    class Account_detail
    {
        public string name;      // feilds
        public string email;
        public int password;
        public decimal balance;

        public Account_detail(string P_name, string P_mail, int P_password, decimal P_balance)
        {
            name = P_name;
            email = P_mail;          // in ctor """"""""""""field variable = the parameters"""""""
            password = P_password;
            balance = P_balance;
        }


        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine(amount + " debited from your account");
                Console.WriteLine("Available Balance = " + balance);
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance");
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount >= 500 && amount <= 10000)
            {

                
                balance = balance + amount;
                Console.WriteLine(amount + "deposited to your account");
                Console.WriteLine("Available balance in the account is" + balance);

            }
            else
            {
                Console.WriteLine("Deposit only above 500 and under 10000");
            }
        }
    }
}