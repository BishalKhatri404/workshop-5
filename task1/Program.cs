using System;

class Program
{
    static void Main(string[] args)
    {
        // Create BankAccount object
        BankAccount acc = new BankAccount("ACC12345", 5000);

        // Display account number
        Console.WriteLine("Account Number: " + acc.AccountNumber);

        // Deposit money
        acc.Deposit(2000);
        Console.WriteLine("After depositing 2000, Balance: " + acc.Balance);

        // Withdraw money
        acc.Withdraw(1500);
        Console.WriteLine("After withdrawing 1500, Balance: " + acc.Balance);

        // Final remaining balance
        Console.WriteLine("Remaining Balance: " + acc.Balance);

        Console.ReadLine();
    }
}
