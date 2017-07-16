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
                        
            Savings_Account savings = new Savings_Account(123456, 500, "Savings Account", .005d);
                       
            Checking_Account checking = new Checking_Account(11111111, 200000, "Checking Account");

            //Functional menu created 
            string openingCommand;
            string upperOpeningCommand;

            do
            {                
                Console.WriteLine("\n1.View Client Information \n2.View Account Balance\n3.Deposit Funds \n4.Withdraw Funds \n5.Exit \n");                
                openingCommand = Console.ReadLine();
                upperOpeningCommand = openingCommand.ToUpper();
                //Console.Clear(); I feel that the console looks much "cleaner" after being cleared, but this interfered with the console format required for this assignment

                //Client Information
                if (upperOpeningCommand == "VIEW CLIENT INFORMATION")
                {
                    Console.WriteLine(jack.ViewInfo());
                }

                //View Account Balance
                else if (upperOpeningCommand == "VIEW ACCOUNT BALANCE")
                {
                    Console.WriteLine("\n2 \na. Checking Account Balance \nb. Savings Account Balance\n");
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
                    Console.WriteLine("\n2 \n\na. Savings Account \nb. Checking Account\n");
                    string depositChoice = Console.ReadLine();
                    string upperDepositChoice = depositChoice.ToUpper();
                    if (upperDepositChoice == "SAVINGS ACCOUNT")
                    {
                        savings.Deposit();
                        Console.WriteLine("The new balance for your savings account is: " + savings.GetAccountBalance());
                    }
                    else if (upperDepositChoice == "CHECKING ACCOUNT")
                    {
                        checking.Deposit();
                        Console.WriteLine("The new balance for your checking account is: " + checking.GetAccountBalance());
                    }
                }

                //Withdraw Funds
                else if (upperOpeningCommand == "WITHDRAW FUNDS")
                {
                    Console.WriteLine("\n2 \n\na. Savings Account \nb. Checking Account\n");
                    string withdrawChoice = Console.ReadLine();
                    string upperWithdrawChoice = withdrawChoice.ToUpper();
                    if (upperWithdrawChoice == "SAVINGS ACCOUNT")
                    {                      
                        savings.Withdraw();
                        Console.WriteLine("The new balance for your savings account is: " + savings.GetAccountBalance());                        
                    }
                    else if (upperWithdrawChoice == "CHECKING ACCOUNT")
                    {
                        checking.Withdraw();
                        Console.WriteLine("The new balance for your checking account is: " + checking.GetAccountBalance());
                    }
                }
                //Exit Program & and invalid command text          
                else
                {
                    if (upperOpeningCommand == "EXIT")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please type a valid command");
                    }
                }

            } while (upperOpeningCommand != "EXIT");
                                    
        }
    }
}
