using Lab2.Task1.Subscriptions;

namespace Lab2.Task1.Factories;


public class ManagerCall : ISubscriptionFactory
{
    public ISubscription CreateSubscription(string country, int months, string? studentId)
    {
        // We don't want to bother with the students on the phone
        return (country == "US") ? new DomesticSubscription() : new PremiumSubscription();
    }
}