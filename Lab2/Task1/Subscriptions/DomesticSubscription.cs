namespace Lab2.Task1.Subscriptions;

public class DomesticSubscription : ISubscription
{
    public string Name => "Domestic";
    public decimal MonthlyFee => 9.99m;
    public int MinMonthDuration => 3;
    public List<string> Channels => ["BBC", "CNN", "Discovery"];
    public List<string> Features => ["HD", "Opus Audio"];
}
