public class TrustAccount : Account
{

    public double Interestrate { get; set; }
    public int WithdrawCount { get; set; }
    public TrustAccount(string Name = "Unnamed Account", double Balance = 0.0, double Interestrate = 3.0) : base(Name, Balance)
    {
        this.Interestrate = Interestrate;
    }

    public override bool Deposit(double amount)
    {
        double Bouns = 50.0;
        if (amount >= 5000)
        {
            amount += Bouns;

        }
        return base.Deposit(amount);
    }

    public override bool Withdraw(double amount)
    {

        if (WithdrawCount < 3 && Balance * 0.2 > amount)
        {
            WithdrawCount += 1;
            return base.Withdraw(amount);
        }
        else
        {
            return false;
        }
    }

}