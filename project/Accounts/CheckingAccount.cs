public class CheckingAccount : Account
{
    public CheckingAccount(string Name = "Unnamed Account", double Balance = 0.0) : base(Name, Balance)
    {
            
    }
    public override bool Withdraw(double amount)
    {
        double Fees = 1.5;
        return base.Withdraw(amount + Fees);
    }
}