class ATM
{
    public int account_no;
    public String account_holder_name;
    public double avaliable_balance;

    public ATM(int acc_no, String acc_name, double ava_bal)
    {
        this.account_no = acc_no;
        this.account_holder_name = acc_name;
        this.avaliable_balance = ava_bal;
    }
}

public delegate void WatchBalance(double n);

class Program
{

    public static void checkBalance(double bal)
    {
        if (bal < 0)
        {
            Console.WriteLine("You are overdrawn");
        }
        else if (bal < 10)
        {
            Console.WriteLine("Your account balance is very low");
        }
        else if (bal < 100)
        {
            Console.WriteLine("Watch your spending carefully.");
        }
        else
        {
            Console.WriteLine("You have over $100 in your account");
        }
    }

    static void Main()
    {

        WatchBalance watch = checkBalance;
        ATM ac1 = new ATM(200012232, "Rushita", 100);
        watch(ac1.avaliable_balance);
        Console.WriteLine("Ms. " + ac1.account_holder_name + " your current balance is " + ac1.avaliable_balance);

        Console.WriteLine("*********************");

        ATM ac2 = new ATM(200012255, "Harsh", -400);
        watch(ac2.avaliable_balance);
        Console.WriteLine("Mr. " + ac2.account_holder_name + " your current balance is " + ac2.avaliable_balance);

        Console.WriteLine("*********************");

        ATM ac3 = new ATM(200012222, "Aishwarya", 10);
        watch(ac3.avaliable_balance);
        Console.WriteLine("Ms. " + ac3.account_holder_name + " your current balance is " + ac3.avaliable_balance);

        Console.WriteLine("*********************");

        ATM ac4 = new ATM(200012291, "Yakshi", 50);
        watch(ac4.avaliable_balance);
        Console.WriteLine("Ms. " + ac4.account_holder_name + " your current balance is " + ac4.avaliable_balance);

    }
}