using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Savings_Account : Accounts_Template
    {
        

        public Savings_Account()
        {
            //Default
        }
        public Savings_Account(int accountNumber, double balance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
        }
                     
                        
        //"Savings account must include a minimum balance. User can't withdraw below minimum"
        //public override double Withdraw()
        //{
        //    if ( < 200)
        //    {
        //        Console.WriteLine("Insufficient funds. Minimum balance for a savings account is 200$.");
        //        return 0.00d;
        //    }
        //    else
        //    {
        //        double withdrawAmmount = double.Parse(Console.ReadLine());
        //        balance += withdrawAmmount;
        //        return withdrawAmmount;

           // }
        //}
    }
}
