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
                
        //Don't forget to put a limit on savings withdraw. If client has less than 200$ he/she can't withdraw!

        public virtual double SavingsWithdraw()
        {
            double withdrawAmmount = double.Parse(Console.ReadLine());
            balance += withdrawAmmount;

            return withdrawAmmount;
        }
    }
}
