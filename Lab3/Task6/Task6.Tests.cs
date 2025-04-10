// dotnet test --filter Lab3.Task6 --logger="console;verbosity=detailed"

using Lab3.Task6;
using Lab3.Task6.Nodes;
using System.Diagnostics;
using System.Text;
using Xunit;
using Xunit.Abstractions;


namespace Lab3.Task6.Tests;

public class FlyweightTests
{
    private readonly string text;
    private readonly ITestOutputHelper output;

    public FlyweightTests(ITestOutputHelper output)
    {
        using var client = new HttpClient();
        var url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
        this.text = client.GetStringAsync(url).GetAwaiter().GetResult();
        this.output = output;
    }

    [Fact]
    public void LightHTMLFlyweightTest()
    {
        long memory0 = Process.GetCurrentProcess().PrivateMemorySize64;

        LightElementNode root = Parser.Parse(new StringReader(this.text));
        Assert.True(root.OuterHTML.Length > this.text.Length);

        long memory1 = Process.GetCurrentProcess().PrivateMemorySize64;
        output.WriteLine($"Memory usage: {(memory1 - memory0) / 1024} Kbytes");
    }
}