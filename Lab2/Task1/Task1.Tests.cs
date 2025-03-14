using Lab2.Task1.Factories;
using Lab2.Task1.Subscriptions;
using Xunit;

namespace Lab2.Task1.Tests;


public class FactoriesTests
{
    [Fact]
    public void ManagerCall()
    {
        ISubscriptionFactory factory = new ManagerCall();
        Assert.IsType<PremiumSubscription>(CreateSubscription(factory, "UA", 12, null));
        Assert.IsType<DomesticSubscription>(CreateSubscription(factory, "US", 12, "IPZ231"));
    }

    [Fact]
    public void MobileApp()
    {
        ISubscriptionFactory factory = new MobileApp();
        Assert.IsType<PremiumSubscription>(CreateSubscription(factory, "US", 12, null));
        Assert.IsType<EducationalSubscription>(CreateSubscription(factory, "UA", 12, "IPZ231"));
    }

    [Fact]
    public void WebSite()
    {
        ISubscriptionFactory factory = new WebSite();
        Assert.IsType<PremiumSubscription>(CreateSubscription(factory, "UA", 12, null));
        Assert.IsType<EducationalSubscription>(CreateSubscription(factory, "UA", 12, "IPZ231"));
        Assert.IsType<DomesticSubscription>(CreateSubscription(factory, "US", 12, "IPZ231"));
    }

    public ISubscription CreateSubscription(ISubscriptionFactory factory, string country, int months, string? studentId)
    {
        return factory.CreateSubscription(country, months, studentId);
    }
}
