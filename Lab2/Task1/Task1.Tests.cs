using Lab2.Task1.Factories;
using Lab2.Task1.Subscriptions;
using Xunit;

namespace Lab2.Task1.Tests;


public class FactoriesTests
{
    [Fact]
    public void ManagerCall()
    {
        IFactory factory = new ManagerCall();
        Assert.Equal("Premium", CreateSubscription(factory, "UA", 12, null).Name);
        Assert.Equal("Domestic", CreateSubscription(factory, "US", 12, "IPZ231").Name);
    }

    [Fact]
    public void MobileApp()
    {
        IFactory factory = new MobileApp();
        Assert.Equal("Premium", CreateSubscription(factory, "US", 12, null).Name);
        Assert.Equal("Educational", CreateSubscription(factory, "UA", 12, "IPZ231").Name);
    }

    [Fact]
    public void WebSite()
    {
        IFactory factory = new WebSite();
        Assert.Equal("Premium", CreateSubscription(factory, "UA", 12, null).Name);
        Assert.Equal("Educational", CreateSubscription(factory, "UA", 12, "IPZ231").Name);
        Assert.Equal("Domestic", CreateSubscription(factory, "US", 12, "IPZ231").Name);
    }

    public ISubscription CreateSubscription(IFactory factory, string country, int months, string? studentId)
    {
        return factory.CreateSubscription(country, months, studentId);
    }
}
