using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Savings_Account : Accounts_Template
    {        
        //One required property and its field.
        protected double interest;
        public double Interest { get; }                

        public Savings_Account()
        {
            //Default
        }
        public Savings_Account(int accountNumber, double balance, string accountType, double interest)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
            this.interest = interest;
        }
         //Possible useful method for the bank, if not the user. 
          public void InterestAccrewal()
        {
            balance =+ (balance*interest);            
        }
                
        public override double Withdraw()
        {
            if (balance < 200)
            {
                Console.WriteLine("Insufficient funds. Minimum balance for a savings account is 200$.");
                return 0.00d;
            }
            else
            {
                double withdrawAmmount = double.Parse(Console.ReadLine());
                balance -= withdrawAmmount;
                return withdrawAmmount;
            }
        }



    }
}
