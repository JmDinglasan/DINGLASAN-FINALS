using System;
using System.Collections.Generic;

public class FINALSUSINGMETHOD
{
    static string? transac;
    static int withdraw, depo, receipt, found, pass, pin;

    static List<string?> accounts = new List<string?>();

    public static void Main(String[]args)
    {
        System.Console.WriteLine("-----------------------------------------");
        System.Console.WriteLine("Good day! Welcome to ProLife Banking.");
        System.Console.WriteLine("-----------------------------------------");
        System.Console.WriteLine(" ");

        while(transac != "6")
        {
            ShowMainMenu();

            GetInputUser();

            switch(transac)
            {
                case "1":
                ShowImportantNote();
                OpenAnAccount();
                System.Console.WriteLine("Your account now is Open! You can now proceed to transactions.");
                System.Console.WriteLine(" ");
                break;

                case "2":
				Console.Write("Enter your account number: ");
				var acc = Console.ReadLine();
				
				if(DoesAccountExist(acc))   
				{
					InsertYourPin();
					Withdrawal();
				}
				else
				{
                    NoAccountDetected();
				}
				break;

                case "3":
				Console.Write("Enter your account number: ");
				var acco = Console.ReadLine();
			
				if(DoesAccountExist(acco))
				{
                    InsertYourPin();
                    Deposit();
				}
				else
				{
                    NoAccountDetected();
				}
				break;

                case "4":
				Console.Write("Enter your account number: ");
				var accou = Console.ReadLine();
			
				if(DoesAccountExist(accou))
				{
                    InsertYourPin();
                    BalInquiry();
				}
				else
				{
                    NoAccountDetected();
				}
				break;

                case "5":
				Console.Write("Enter your account number: ");
				var accoun = Console.ReadLine();
				
				if(DoesAccountExist(accoun))
				{
                   InsertYourPin();
                   ViewTransactionHistory();
				}
				else
				{
                    NoAccountDetected();
				}
				break;

                case "6":
                System.Console.WriteLine("Thank you for using ProLife Banking!");
                break;

                default:
				Console.WriteLine("Enter number only based on the given transactions.");
                System.Console.WriteLine(" ");
				break;
            }

        }
    }
    
    static void ShowMainMenu()   //method signature
    {
            System.Console.WriteLine("Here are the Available Transactions: ");
            System.Console.WriteLine("Press 1 to Create an Account");
            System.Console.WriteLine("Press 2 to Withdraw");
            System.Console.WriteLine("Press 3 to Deposit");
            System.Console.WriteLine("Press 4 to Check Your Balance");
            System.Console.WriteLine("Press 5 to View Your Transactions");
            System.Console.WriteLine("Press 6 to Exit");
            System.Console.WriteLine(" ");
    }
    static void GetInputUser()
    {   
        System.Console.Write("User input: ");
        transac = Console.ReadLine();
        System.Console.WriteLine(" ");
    }
    static void ShowImportantNote()
    {
        System.Console.WriteLine("IMPORTANT NOTE!!");
        System.Console.WriteLine("Your account number should only contain 12-DIGITS.");
        System.Console.WriteLine("Your PIN should only contain 6-DIGITS.");
        System.Console.WriteLine(" ");
    }
    static void OpenAnAccount()
    {
        System.Console.Write("Create your account number: ");
        accounts.Add(Console.ReadLine());
        System.Console.Write("Create your pin: ");
        pin = Convert.ToInt32(Console.ReadLine());
    }
    static bool DoesAccountExist(string? AccountNumber) //parameters 
    {
        int found = accounts.IndexOf(AccountNumber);

        if(found == -1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    static void InsertYourPin()
    {
    	Console.Write("Insert your pin: ");
		pass = Convert.ToInt32(Console.ReadLine());
    }
    static void Withdrawal()
    {
        if(pass == pin)
		{
			Console.Write("Enter your desired amount of withdrawal: ");
			withdraw = Convert.ToInt32(Console.ReadLine());
				
			if(withdraw > depo)
			{
				Console.WriteLine("Your balance is Insufficient! Please make a deposit first.");
				Console.WriteLine(" ");
			}
			else if(withdraw <= depo)
			{
				Console.WriteLine("Your Withdrawal is Successful!");
				Console.WriteLine(" ");
				receipt = depo - withdraw;
						
				Console.WriteLine("Your Balance is now: "+receipt);
				Console.WriteLine("Thank you for your transaction!");
				Console.WriteLine(" ");
			}
			else
			{
				Console.WriteLine("You have 0 balance in your account. Please make a deposit first");
				Console.WriteLine(" ");
			}
		}
		else
		{
			Console.WriteLine("Your pin is incorrect! Please try again.");
			Console.WriteLine(" ");
		}
    }
    static void Deposit()
    {
		if(pass == pin)
		{
			Console.Write("Enter the Amount of Deposit: ");
			depo = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Deposit Successful!");
			Console.WriteLine(" ");
		}
		else
		{
		    Console.WriteLine("Your pin is incorrect! Please try again.");
			Console.WriteLine(" ");
		}
    }
    static void BalInquiry()
    {
		if(pass == pin)
		{
			if(depo == 0)
			{
				Console.WriteLine(" ");
				Console.WriteLine("You have 0 balance on your account.");
				Console.WriteLine(" ");
			}
			else if(receipt > 0)
			{
				Console.WriteLine("Your balance is "+receipt);
				Console.WriteLine(" ");
			}
			else
			{
				Console.WriteLine("Your balance is "+depo);
				Console.WriteLine(" ");
			}
		}
    }
    static void ViewTransactionHistory()
    {			
		if(pass == pin)
		{
		    Console.WriteLine("Below are your recent transactions: ");
			Console.WriteLine(" ");
						
			if((depo > 0) && (withdraw > 0) && (receipt >= 0 ))
			{
				Console.WriteLine("You have deposited: "+depo);
				Console.WriteLine("You have withdrawn: "+withdraw);
				Console.WriteLine("You did a balance inquiry.");
				Console.WriteLine(" ");
			}
			else if(depo > 0 && receipt >= 0)
			{
				Console.WriteLine("You have deposited: "+depo);
				Console.WriteLine("You did a balance inquiry.");
				Console.WriteLine(" ");
			}
			else if((depo > 0) && (withdraw > 0))
			{	
				Console.WriteLine("You have deposited: "+depo);
				Console.WriteLine("You have withdrawn: "+withdraw);
				Console.WriteLine(" ");
			}
			else if(receipt >= 0)
			{
				Console.WriteLine("You did a balance inquiry.");
				Console.WriteLine(" ");
			}
			else
			{
				Console.WriteLine("There were no transactions made on this account.");
				Console.WriteLine(" ");
			}
		}
		else
		{
			Console.WriteLine("Your pin is incorrect! Please try again.");
			Console.WriteLine(" ");
		}
    }
    static void NoAccountDetected()
    {
     	Console.WriteLine("Your account does not exist! Please create an account first.");
		Console.WriteLine(" ");
    }
}