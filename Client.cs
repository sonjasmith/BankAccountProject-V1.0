using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //variables/fields
        private string clientNameVar;
        private string clientAddressVar;
        private string clientEmailVar;

        //constructor
        public Client()
        {
            ClientNameProp = "The S Brand";
            ClientAddressProp = "123 Brand Blvd";
            ClientEmailProp = "hello@thesbrand.com";
        }

        //properites
        public string ClientNameProp
        {
            set { this.clientNameVar = value; }
            get { return this.clientNameVar; }
        }

        public string ClientAddressProp
        {
            set { this.clientAddressVar = value; }
            get { return this.clientAddressVar; }
        }

        public string ClientEmailProp
        {
            set { this.clientEmailVar = value; }
            get { return this.clientEmailVar; }
        }

        //method
        public void ShowClientInfo()
        {
            Console.WriteLine("YOUR ACCOUNT INFORMATION: ");
            Console.WriteLine(ClientNameProp);
            Console.WriteLine(ClientAddressProp);
            Console.WriteLine(ClientEmailProp + "\n");
        }
    }
}
