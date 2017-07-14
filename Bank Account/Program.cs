using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part One: Create functional menu that allows for further options to be opened up at user's choice. 

            Console.WriteLine("Welcome to your personal bank account system! \nPlease choose your action from the following \n View Client Information \nView Account Balance\n Withdraw Funds \n Exit");
            string openingCommand = Console.ReadLine();
            string upperOpeningCommand = openingCommand.ToUpper();

            if (upperOpeningCommand == "VIEW CLIENT INFORMATION")
            {

            }

            else if (upperOpeningCommand == "VIEW ACCOUNT BALANACE")
            {
                Console.WriteLine("Please select from the following: \nChecking Account Balance \nSavings Account Balance");
                string
            }

            else if (upperOpeningCommand == "DEPOSIT FUNDS")
            {

            }

            else if (upperOpeningCommand == "WITHDRAW FUNDS")
            {

            }

            else if (upperOpeningCommand == "EXIT")
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Please type a valid command");
            }
                      

           
            //- [ ] View Account Balance
            //  - [ ] Checking Account Balance
            //  - [ ] Savings Account Balance
            //- [ ] Deposit Funds
            //  - [ ] To Checking Account
            //  - [ ] To Savings Account
            //- [ ] Withdraw Funds
            //  - [ ] From Checking Account
            //  - [ ] From Savings Account
            
        }
    }
}
