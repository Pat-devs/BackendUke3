class BankAccount
{
    public string OwnerName { get; set; }
    public decimal Balance { get; set; }
    
    public BankAccount(string ownername)
    {
        // base account setup
        OwnerName = ownername;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
    }

    public void ShowBalance()
    {
        Console.WriteLine(OwnerName + " has " + Balance + " NOK.");
    }
} 