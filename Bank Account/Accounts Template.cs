using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    abstract class Accounts_Template
    {        
        protected int accountNumber;
        protected double balance;
        protected string accountType;
                
        public int AccountNumber {get;}
        public double Balance { get; set; }
        public string AccountType {get;}
                
        public Accounts_Template()
        {
            //default
        }

        public Accounts_Template(int accountNumber, double balance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
        }          

        //Methods
        
        public virtual double Withdraw()
        {
            double withdrawAmmount = double.Parse(Console.ReadLine());
            balance -= withdrawAmmount;
            return withdrawAmmount;
            
        }
        public virtual double Deposit()
        {
            double depositAmmount = double.Parse(Console.ReadLine());
            balance += depositAmmount;
            return depositAmmount;
        }

        public virtual string GetAccountBalance()
        {
            return "Account Balance:" + balance;
        }
        //originally intended to make this static instead of virtual, but...
        //...for reasons unknown, balance malfunctions under a static method.

        public abstract void Exit();

        //Discovered last minute that we needed an abstract method. While it is implemented in the Savings_Account...
        // and in the main program, this method is somewhat superfluous, but it meets the project requirements.

    }
}
