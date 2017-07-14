using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Savings_Account : Accounts_Template
    {
        //Constructor
        public Savings_Account(int accountNumber, double balance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
        }

        //Methods

        public static double Deposit()
        {
            double depositAmmount = double.Parse(Console.ReadLine());
            return depositAmmount;
        }

        //Don't forget to put a limit on savings withdraw. If client has less than 200$ he/she can't withdraw!

        public static double Withdraw()
        {
            double withdrawAmmount = double.Parse(Console.ReadLine());

            return withdrawAmmount;
        }
    }
}
