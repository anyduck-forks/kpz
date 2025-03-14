namespace Lab2.Task1.Subscriptions;

public interface ISubscription
{
    public string Name { get; }
    public decimal MonthlyFee { get; }
    public int MinMonthDuration { get; }
    public List<string> Channels { get; }
    public List<string> Features { get; }
}
