using System.Text.RegularExpressions;
using Xunit;

namespace Lab3.Task4.Tests;


public class ProxiesTests
{
    [Fact]
    public void SmartTextCheckerTest()
    {
        string path = Path.GetTempFileName();
        File.WriteAllText(path, "Hello\nWorld");

        ISmartTextReader _reader = new SmartTextReader();
        var output = new StringWriter();
        ISmartTextReader reader = new SmartTextChecker(_reader, output);

        char[][] text = reader.ReadText(path);
        Assert.Equal(2, text.Length);
        Assert.Equal("Hello", new string(text[0]));
        Assert.Equal("World", new string(text[1]));
        var expectedOutput = new string[]
        {
            "Opening file: " + path,
            "File " + path + " read successfully.",
            "Total lines: 2, Total characters: 10",
            "Closing file: " + path,
            ""
        };
        Assert.Equal(expectedOutput, output.GetStringBuilder().ToString().Split(Environment.NewLine));
    }

    [Fact]
    public void SmartTextReaderLocker()
    {
        var dir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(dir);
        ISmartTextReader _reader = new SmartTextReader();
        ISmartTextReader reader = new SmartTextReaderLocker(_reader, [new Regex("secret.*")]);

        var blockPath = Path.Combine(dir, "secret.txt");
        File.WriteAllText(blockPath, "This is a secret.");

        char[][] text1 = reader.ReadText(blockPath);
        Assert.Empty(text1);

        var allowPath = Path.Combine(dir, "benine.txt");
        File.WriteAllText(allowPath, "This is a not secret.");

        char[][] text2 = reader.ReadText(allowPath);
        Assert.Equal("This is a not secret.", new string(text2[0]));
    }
}