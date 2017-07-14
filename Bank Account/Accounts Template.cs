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
        public double Balance {get;}
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
    }
}
