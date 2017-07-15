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
            
            //Client Instance
            Client jack = new Client("Jack Vettriano", "Famed Painter", 24, "6716 Princess Gardens, KnightsBridge, London");

            //Savings Instance
            Savings_Account savings = new Savings_Account(11111111, 300000, "Savings Account");

            //Checking Instance
            Checking_Account checking = new Checking_Account(11111111, 200000, "Checking Account");

            //Menu Items: Create functional menu that allows for further options to be opened up at user's choice. 

            Console.WriteLine("Welcome to your personal bank account system! \nPlease choose your action from the following: \nView My Information \nView Account Balance\nWithdraw Funds \nDeposit Funds \nExit");
            string openingCommand = Console.ReadLine();
            string upperOpeningCommand = openingCommand.ToUpper();

            if (upperOpeningCommand == "VIEW MY INFORMATION")
            {
                Console.WriteLine(jack.ViewInfo());
            }

            else if (upperOpeningCommand == "VIEW ACCOUNT BALANCE")
            {
                Console.WriteLine("Please select from the following: \nChecking Account Balance \nSavings Account Balance");
                string accountBalance = Console.ReadLine();
                string upperAccountBalance = accountBalance.ToUpper();
                if (upperAccountBalance == "CHECKING ACCOUNT BALANCE")
                {
                    Console.WriteLine("Your balance is" + checking.GetAccountBalance()); 
                }
                else if ((upperAccountBalance == "SAVINGS ACCOUNT BALANCE"))
                {
                    Console.WriteLine("Your balance is" + savings.GetAccountBalance());
                }
            }

            else if (upperOpeningCommand == "DEPOSIT FUNDS")
            {
                Console.WriteLine("Which of the following accounts would you like to make a deposit in? \nSavings Account \nChecking Account");
                string depositChoice  = Console.ReadLine();
                string upperDepositChoice = depositChoice.ToUpper();
                if(upperDepositChoice == "SAVINGS ACCOUNT")
                {
                    savings.Deposit();
                    Console.WriteLine("The new balance for your savings account is: " + savings.Balance );
                }
                else if(upperDepositChoice == "CHECKING ACCOUNT")
                {
                    checking.Deposit();
                    Console.WriteLine("The new balance for your checking account is: " + checking.Balance);
                }
            }

            else if (upperOpeningCommand == "WITHDRAW FUNDS")
            {
                Console.WriteLine("Which of the following accounts would you like to make a withdraw? \nSavings Account \nChecking Account");
                string withdrawChoice = Console.ReadLine();
                string upperWithdrawChoice = withdrawChoice.ToUpper();
                if (upperWithdrawChoice == "SAVINGS ACCOUNT")
                {
                    savings.Withdraw();
                    Console.WriteLine("The new balance for your savings account is: " + savings.Balance);
                }
                else if (upperWithdrawChoice == "CHECKING ACCOUNT")
                {
                    checking.Withdraw();
                    Console.WriteLine("The new balance for your checking account is: " + checking.Balance);
                }
            }

            else if (upperOpeningCommand == "EXIT")
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Please type a valid command");            
            }        
                                    
        }
    }
}
