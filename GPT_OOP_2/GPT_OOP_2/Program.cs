/*
 * Encapsulation: Create a class BankAccount with properties Balance and AccountNumber. 
 * Create methods Deposit() and Withdraw() that modify the Balance property. 
 * Make the Balance property read-only. Add a property InterestRate that is set to 0.05 by default. 
 * Create a method CalculateInterest() that calculates the interest on the account balance. 
 * Create an instance of the BankAccount class and call its Deposit(), Withdraw(), and CalculateInterest() methods.
*/

public class BankAccount
{
    private int Account_Number { get; set; }
    private float Balance { get; set; }
    private float Interest_Rate = 0.05f;

    public void Deposit(int balance)
    {
        if (Balance == 0)
        {
            Balance = balance;
        }
        else
        {
            Balance += balance;
        }
        Console.WriteLine($"Balance: {Balance}");
    }

    public void Withdraw(int balance)
    {
        if (Balance <= 0)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            Balance -= balance;
        }
        Console.WriteLine($"Balance: {Balance}");
    }

    public void CalculateInterest()
    {
        Console.WriteLine($"Interest Amount: {Balance * Interest_Rate}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount Blake_Account = new BankAccount();
        Blake_Account.Deposit(1000);
        Blake_Account.Withdraw(200);
        Blake_Account.CalculateInterest();
    }
}