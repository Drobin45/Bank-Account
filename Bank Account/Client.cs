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
        protected string clientAddress;

        //Client properties
        public string ClientName {get;}
        public string Occupation {get; set;}
        public double MoneyInWallet {get; set;}
        public string ClientAddress {get; set;}        

        //Client constructors
        public Client()
        {
            //Default
        }

        public Client(string clientName, string occupation, double moneyInWallet, string clientAddress)
        {
            this.clientName = clientName;
            this.occupation = occupation;
            this.moneyInWallet = moneyInWallet;
            this.clientAddress = clientAddress;            
        }

        //Methods
        public virtual string ViewInfo()
        {
            return "Name:" + clientName + "\n" + "Occupation:" + occupation + "Address:" + clientAddress;
        }      



    }
}
