namespace N9_CL_Program_Tutorials.P11;

/// <summary>
/// Question 7 (a)
/// </summary>
public abstract class BankAccount
{
    private decimal _balance;

    protected BankAccount(int acctNum, decimal amount)
    {
        AcctNumber = acctNum;
        Balance = amount;
    }

    public int AcctNumber { get; }

    protected decimal Balance
    {
        get => _balance;
        set => _balance = value;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    protected virtual void Withdraw(decimal amount)
    {
        if (amount < 0)
            throw new Exception("Cannot withdraw a negative amount");
    }

    public abstract void AddInterest();
}