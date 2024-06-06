namespace ATM;

class Program
{
    public static decimal Balance = 100;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the atm!\n\n");

        Console.WriteLine("Choose an option:");
        Console.WriteLine("To view balance, press 1");
        Console.WriteLine("To widthdraw, press 2");
        Console.WriteLine("\n");

        string input = Console.ReadLine();

        if(input == "1"){
            decimal balance = ViewBalance();
            Console.WriteLine("This is the current balance: " + balance);
        }
        else if (input == "2"){
            Console.Write("What is the widthdraw amount? ");
            string widthdrawAmountString = Console.ReadLine();
            decimal widthdrawAmount = Convert.ToDecimal(widthdrawAmountString);
            decimal newAccountBalance =  Widthdraw(widthdrawAmount);
            Console.WriteLine("The new balance is " + newAccountBalance);
        }
    }

    static decimal ViewBalance(){
        return Balance;
    }

    static decimal Widthdraw(decimal widthdrawAmount){
        if (Balance < widthdrawAmount){
            throw new Exception("Insufficient funds!: You aint got no moneyyy!");
        }

        else if (widthdrawAmount < 0){
            throw new Exception("Invalid widthdrawl amount");
        }
            

       decimal newBalance = Balance - widthdrawAmount;
       return newBalance;

    }





}
