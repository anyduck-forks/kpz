namespace Lab2.Task1.Subscriptions;

public class PremiumSubscription : ISubscription
{
    public string Name => "Premium";
    public decimal MonthlyFee => 19.99m;
    public int MinMonthDuration => 1;
    public List<string> Channels => ["BBC", "CNN", "Discovery", "Fox", "NBC"];
    public List<string> Features => ["HD", "4K", "Opus Audio", "Dolby Atmos"];
}
