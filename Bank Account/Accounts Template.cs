using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    abstract class Accounts_Template
    {
        //Fields
        protected int accountNumber;
        protected double balance;
        protected string accountType;

        //Properties
        public int AccountNumber {get;}
        public double Balance { get; set; }
        public string AccountType {get;}

        //Constructors
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

      
        //public virtual double Withdraw()
        //{
        //    double withdrawAmmount = double.Parse(Console.ReadLine());
        //    balance += withdrawAmmount;
        //    return withdrawAmmount;
        //}

        public virtual void Withdraw()
        {

            balance += 20;
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
    }
}
