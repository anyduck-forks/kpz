using Lab2.Task1.Subscriptions;

namespace Lab2.Task1.Factories;


public class MobileApp : ISubscriptionFactory
{
    public ISubscription CreateSubscription(string country, int months, string? studentId)
    {
        // Suppose that Apple forbids discimination by the country of origin xD
        return (studentId != null) ? new EducationalSubscription() :  new PremiumSubscription();
    }
}