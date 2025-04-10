// dotnet test --filter Lab3.Task6 --logger="console;verbosity=detailed"
//
// This LightHTML language is supposed to be similar to Markdown
// so the style are defined by the text itself and not by css
// therefore font properties and layout are extrinsic to the tag
//
// 4000 Kbytes before Flyweight
// 2336 Kbytes after Flyweight

using Lab3.Task6.Nodes;
using System.Diagnostics;
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