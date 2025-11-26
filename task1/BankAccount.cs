public class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Public property – only getter
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property – getter, private setter
    // Ensures balance can never be 0 or negative
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                throw new Exception("Balance must be greater than 0.");
            }
        }
    }

    // Constructor – accountNumber set here, and initial balance must be positive
    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;
        Balance = initialBalance; // uses property validation
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new Exception("Deposit amount must be greater than 0.");
        }

        balance += amount;
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new Exception("Withdraw amount must be greater than 0.");
        }

        if (amount > balance)
        {
            throw new Exception("Insufficient balance.");
        }

        balance -= amount;
    }
}
