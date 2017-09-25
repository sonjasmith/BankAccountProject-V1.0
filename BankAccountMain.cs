using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccountMain

    {
        static void Main(string[] args)
        {
            //testing client object
            //instantiate one client object
            Client clientInst = new Client();
            //clientInst.ShowClientInfo();

            //testing checking object
            //instantiate one checking object
            Checking checkingInst = new Checking();
            //checkingInst.showCurrentBalance();
            //checkingInst.depositFunds(1000m);
            //checkingInst.withdrawFunds(200m);

            //testing savings object
            //instantiate one savings object
            Savings savingsInst = new Savings();
   
            string strMenuChoice;
            int menuChoice;

            //display state
                do
                {
                    //Menu layout
                    Console.WriteLine("Please make a selection of 1, 2, 3, 4 or 5 below: ");
                    Console.WriteLine();
                    Console.WriteLine("1) View Client Information");
                    Console.WriteLine("2) View Account Balance");
                    Console.WriteLine("3) Deposit Funds");
                    Console.WriteLine("4) Withdraw Funds");
                    Console.WriteLine("5) Exit");
                    Console.WriteLine("\n");

                    //Processed menu options
                    strMenuChoice = Console.ReadLine();
                    menuChoice = int.Parse(strMenuChoice);

                    switch (menuChoice)
                    {
                        case 1:
                            clientInst.ShowClientInfo();
                            break;
                        case 2:
                            Console.WriteLine("Enter C for checking or S for savings: ");
                            string balanceOption = Console.ReadLine();
                            if (balanceOption.ToLower() == "c")
                            {
                            checkingInst.showCurrentBalance();
                            }
                            else if(balanceOption.ToLower() == "s")
                            {
                            savingsInst.showCurrentBalance();
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter C for checking or S for savings: ");
                            string depositOption = Console.ReadLine();
                            if (depositOption.ToLower() == "c")
                            {
                            Console.WriteLine("Deposit Amount: ");
                            decimal depositAmount = Decimal.Parse(Console.ReadLine());
                            checkingInst.depositFunds(depositAmount);
                            checkingInst.showCurrentBalance();
                            }
                            else if (depositOption.ToLower() == "s")
                            {
                            Console.WriteLine("Deposit Amount: ");
                            decimal depositAmount = Decimal.Parse(Console.ReadLine());
                            savingsInst.depositFunds(depositAmount);
                            savingsInst.showCurrentBalance();
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter C for checking or S for savings: ");
                            string withdrawalOption = Console.ReadLine();
                            if (withdrawalOption.ToLower() == "c")
                            {
                            Console.WriteLine("Withdrawal Amount: ");
                            decimal withdrawalAmount = Decimal.Parse(Console.ReadLine());
                            checkingInst.depositFunds(withdrawalAmount);
                            checkingInst.showCurrentBalance();
                            }
                            else if (withdrawalOption.ToLower() == "s")
                            {
                            Console.WriteLine("Withdrawal Amount: ");
                            decimal withdrawalAmount = Decimal.Parse(Console.ReadLine());
                            savingsInst.depositFunds(withdrawalAmount);
                            savingsInst.showCurrentBalance();
                            }
                            break;
                        case 5:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("I'm sorry, I don't understand that!");
                            break;
                    }
                }
                while (menuChoice != 5);
                System.Environment.Exit(0);
        }
    }
}
