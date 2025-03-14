namespace Lab2.Task1.Subscriptions;

public class EducationalSubscription : ISubscription
{
    public string Name => "Educational";
    public decimal MonthlyFee => 4.99m;
    public int MinMonthDuration => 12;
    public List<string> Channels => ["Discovery"];
    public List<string> Features => ["HD"];
}
