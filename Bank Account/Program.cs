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
            
            //Initializing three primary class instances
            Client jack = new Client("Jack Vettriano", "Famed Painter", 300, "6716 Princess Gardens, KnightsBridge, London");
                        
            Savings_Account savings = new Savings_Account(123456, 500, "Savings Account");
                       
            Checking_Account checking = new Checking_Account(11111111, 200000, "Checking Account");

            //Functional menu created 
            string openingCommand;
            string upperOpeningCommand;

            do
            {                
                Console.WriteLine("View Client Information \nView Account Balance\nDeposit Funds \nWithdraw Funds \nExit");                
                openingCommand = Console.ReadLine();
                upperOpeningCommand = openingCommand.ToUpper();
                Console.Clear();

                //Client Information
                if (upperOpeningCommand == "VIEW CLIENT INFORMATION")
                {
                    Console.WriteLine(jack.ViewInfo());
                }

                //View Account Balance
                else if (upperOpeningCommand == "VIEW ACCOUNT BALANCE")
                {
                    Console.WriteLine("Please select from the following: \nChecking Account Balance \nSavings Account Balance");
                    string accountBalance = Console.ReadLine();
                    string upperAccountBalance = accountBalance.ToUpper();
                    if (upperAccountBalance == "CHECKING ACCOUNT BALANCE")
                    {
                        Console.WriteLine("Your balance is " + checking.GetAccountBalance());
                    }
                    else if ((upperAccountBalance == "SAVINGS ACCOUNT BALANCE"))
                    {
                        Console.WriteLine("Your balance is " + savings.GetAccountBalance());
                    }
                }

                //Deposit Funds
                else if (upperOpeningCommand == "DEPOSIT FUNDS")
                {
                    Console.WriteLine("Which of the following accounts would you like to make a deposit in? \nSavings Account \nChecking Account");
                    string depositChoice = Console.ReadLine();
                    string upperDepositChoice = depositChoice.ToUpper();
                    if (upperDepositChoice == "SAVINGS ACCOUNT")
                    {
                        savings.Deposit();
                        Console.WriteLine("The new balance for your savings account is: " + savings.Balance);
                    }
                    else if (upperDepositChoice == "CHECKING ACCOUNT")
                    {
                        checking.Deposit();
                        Console.WriteLine("The new balance for your checking account is: " + checking.Balance);
                    }
                }

                //Withdraw Funds
                else if (upperOpeningCommand == "WITHDRAW FUNDS")
                {
                    Console.WriteLine("Which of the following accounts would you like to make a withdraw? \nSavings Account \nChecking Account");
                    string withdrawChoice = Console.ReadLine();
                    string upperWithdrawChoice = withdrawChoice.ToUpper();
                    if (upperWithdrawChoice == "SAVINGS ACCOUNT")
                    {
                        if (savings.Balance < 200)
                        {
                            Console.WriteLine("Savings account too low for withraw. The minimum balance required for withdraw is 200$");
                        }
                        else
                        {
                            savings.Withdraw();
                            Console.WriteLine("The new balance for your savings account is: " + savings.Balance);
                        }
                    }
                    else if (upperWithdrawChoice == "CHECKING ACCOUNT")
                    {
                        checking.Withdraw();
                        Console.WriteLine("The new balance for your checking account is: " + checking.Balance);
                    }
                }
                //Exit Program & and invalid command text                

                else
                {
                    Console.WriteLine("Please type a valid command");
                }
                
            } while (upperOpeningCommand != "EXIT");
                                    
        }
    }
}
