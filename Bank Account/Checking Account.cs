using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Checking_Account : Accounts_Template
    {

        public Checking_Account(int accountNumber, double balance, string accountType)
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

        public static double Withdraw()
        {
            double withdrawAmmount = double.Parse(Console.ReadLine());

            return withdrawAmmount;
        }
    }
}
