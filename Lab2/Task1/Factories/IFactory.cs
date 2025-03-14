using Lab2.Task1.Subscriptions;

namespace Lab2.Task1.Factories;


public interface IFactory
{
    public ISubscription CreateSubscription(string country, int months, string? studentId);
}
