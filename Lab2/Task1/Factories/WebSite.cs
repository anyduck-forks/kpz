using Lab2.Task1.Subscriptions;

namespace Lab2.Task1.Factories;


public class WebSite : IFactory
{
    public ISubscription CreateSubscription(string country, int months, string? studentId)
    {
        if (country == "US")
        {
            return new DomesticSubscription();
        }
        if (studentId != null)
        {
            return new EducationalSubscription();
        }
        else
        {
            return new PremiumSubscription();
        }
    }
}