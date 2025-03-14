using Lab2.Task1.Subscriptions;

namespace Lab2.Task1.Factories;


public interface ISubscriptionFactory
{
    public ISubscription CreateSubscription(string country, int months, string? studentId);
}
