using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Client
    {
        //Client fields
        protected string clientName;
        protected string occupation;
        protected double moneyInWallet;

        //Client properties
        public string ClientName {get;}
        public string Occupation {get; set;}
        public double MoneyInWallet {get; set;}

        //Client constructors
        public Client()
        {
            //Default
        }

        public Client(string clientName, string occupation, double moneyInWallet)
        {
            this.clientName = clientName;
            this.occupation = occupation;
            this.moneyInWallet = moneyInWallet;
        }

        //Methods
        public static double Deposit()
        {
            double depositAmmount = double.Parse(Console.ReadLine());
            return depositAmmount;


            //Figure out how to do the below
            //depositAmmount += accountBalance;
            //depositAmmound -= moneyInWallet
        }



        //"Client information should be filled in here" What does this mean?




    }
}
