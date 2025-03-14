
using Lab2.Task2.Devices;
using Lab2.Task2.Factories;
using Xunit;

namespace Lab2.Task2.Tests;


public class FactoriesTests
{
    [Fact]
    public void IProneDevices()
    {
        IFactory factory = new IProneFactory();
        var (laptop, netbook) = CreateDesktops(factory);
        Assert.Equal("M2 Max", laptop.CPU);
        Assert.Equal("M2 Max", laptop.GPU);
        Assert.Equal("32 GB", netbook.Storage);

        var (ebook, smartphone) = CreateHandhelds(factory);
        Assert.Equal("OLED 4K", ebook.Screen);
        Assert.Equal("A12", smartphone.CPU);
    }

 [Fact]
    public void KiaomiDevices()
    {
        IFactory factory = new KiaomiFactory();
        var (laptop, netbook) = CreateDesktops(factory);
        Assert.Equal("Ryzen 5 3900", laptop.CPU);
        Assert.Equal("Vega 8", laptop.GPU);
        Assert.Equal("256 GB", netbook.Storage);

        var (ebook, smartphone) = CreateHandhelds(factory);
        Assert.Equal("IPC 1080p", ebook.Screen);
        Assert.Equal("Snapdragon 860", smartphone.CPU);
    }

    [Fact]
    public void BalaxyDevices()
    {
        IFactory factory = new BalaxyFactory();
        var (laptop, netbook) = CreateDesktops(factory);
        Assert.Equal("i5-8250U", laptop.CPU);
        Assert.Equal("GTX 1050", laptop.GPU);
        Assert.Equal("128 GB", netbook.Storage);

        var (ebook, smartphone) = CreateHandhelds(factory);
        Assert.Equal("AMOLED", ebook.Screen);
        Assert.Equal("Exynos", smartphone.CPU);
    }
   


    public (ILaptop, INetbook) CreateDesktops(IFactory factory)
    {
        return (factory.CreateLaptop(), factory.CreateNetbook());
    }

    public (IEBook, ISmartphone) CreateHandhelds(IFactory factory)
    {
        return (factory.CreateEBook(), factory.CreateSmartphone());
    }
}
