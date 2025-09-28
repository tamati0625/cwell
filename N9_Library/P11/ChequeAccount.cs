namespace N9_Library.P11;

/// <summary>
/// Question 7 (b)
/// </summary>
public class ChequeAccount : BankAccount
{
    public ChequeAccount(int acctNum) : base(acctNum, 0)
    {
    }

    protected override void Withdraw(decimal amount)
    {
        base.Withdraw(amount);
        if (Balance - amount >= -100) //$100 overdraft in cheque account
            Balance -= amount;
        else
            throw new Exception("Withdraw failed, insufficient funds");
    }

    public override void AddInterest()
    {
        Balance += Balance * 0.03m; //3% interest rate
    }
}