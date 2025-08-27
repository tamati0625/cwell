namespace N9_CL_Program_Tutorials.P11;

/// <summary>
/// Question 7 (b)
/// </summary>
public class SavingsAccount : BankAccount
{
    public SavingsAccount(int acctNum, decimal amount) : base(acctNum, amount)
    {
    }

    protected override void Withdraw(decimal amount)
    {
        base.Withdraw(amount);
        if (Balance - amount >= 0) //no overdraft in savings account
            Balance -= amount;
        else
            throw new Exception("Withdraw failed, insufficient funds");
    }

    public override void AddInterest()
    {
        Balance += Balance * 0.07m; //7% interest rate
    }
}