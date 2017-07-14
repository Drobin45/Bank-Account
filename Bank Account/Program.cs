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
            //Menu Items: Create functional menu that allows for further options to be opened up at user's choice. 

            Console.WriteLine("Welcome to your personal bank account system! \nPlease choose your action from the following \nView Client Information \nView Account Balance\nWithdraw Funds \nExit");
            string openingCommand = Console.ReadLine();
            string upperOpeningCommand = openingCommand.ToUpper();

            if (upperOpeningCommand == "VIEW CLIENT INFORMATION")
            {

            }

            else if (upperOpeningCommand == "VIEW ACCOUNT BALANACE")
            {
                Console.WriteLine("Please select from the following: \nChecking Account Balance \nSavings Account Balance");                
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
            //Client Instance
            Client jack = new Client("vettriano", "painter", 24, "KnightsBridge London");

            //Savings Instance
            Savings_Account savings = new Savings_Account(11111111, 300000, "Savings Account");

            //Checking Instance
            Checking_Account checking = new Checking_Account(11111111, 200000, "Checking Account");

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
