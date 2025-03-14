
using Lab2.Task4;
using Xunit;

namespace Lab2.Task4.Tests;


public class PrototypeTests
{
    [Fact]
    public void VirusCloning()
    {
        var gen1_1 = new Virus(9, 50, "Virus A1", "Alpha");
        var gen2_1 = new Virus(5, 25, "Virus B1", "Beta");
        var gen2_2 = new Virus(6, 28, "Virus B2", "Beta");
        gen1_1.Children.Add(gen2_1);
        gen1_1.Children.Add(gen2_2);

        var gen3_1 = new Virus(1, 5, "Virus C1", "Gamma");
        var gen3_2 = new Virus(2, 8, "Virus C2", "Gamma");
        gen2_1.Children.Add(gen3_1);
        gen2_1.Children.Add(gen3_2);


        var gen1_2 = gen1_1.Clone();
        Assert.NotSame(gen1_1, gen1_2);
        Assert.Equal(gen1_1.Weight, gen1_2.Weight);
        Assert.Equal(gen1_1.Age, gen1_2.Age);
        Assert.Equal(gen1_1.Name, gen1_2.Name);
        Assert.Equal(gen1_1.Kind, gen1_2.Kind);

        Assert.NotSame(gen1_1.Children[0], gen1_2.Children[0]);
        Assert.NotSame(gen1_1.Children[1], gen1_2.Children[1]);

        Assert.Equal(gen1_1.Children[0].Weight, gen1_2.Children[0].Weight);
        Assert.Equal(gen1_1.Children[0].Age, gen1_2.Children[0].Age);
        Assert.Equal(gen1_1.Children[0].Name, gen1_2.Children[0].Name);
        Assert.Equal(gen1_1.Children[0].Kind, gen1_2.Children[0].Kind);

        Assert.Equal(gen1_1.Children[1].Weight, gen1_2.Children[1].Weight);
        Assert.Equal(gen1_1.Children[1].Age, gen1_2.Children[1].Age);
        Assert.Equal(gen1_1.Children[1].Name, gen1_2.Children[1].Name);
        Assert.Equal(gen1_1.Children[1].Kind, gen1_2.Children[1].Kind);
    }

}
