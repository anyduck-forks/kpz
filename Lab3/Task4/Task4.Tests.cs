using System.Text.RegularExpressions;
using Xunit;

namespace Lab3.Task4.Tests;

public class ProxiesTests : IDisposable
{
    private DirectoryInfo TempDir;

    public ProxiesTests()
    {
        var dir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        TempDir = Directory.CreateDirectory(dir);
        
        var helloPath = Path.Combine(TempDir.FullName, "hello.txt");
        File.WriteAllText(helloPath, "Hello\nWorld");

        var blockPath = Path.Combine(TempDir.FullName, "secret.txt");
        File.WriteAllText(blockPath, "This is a secret.");
        
        var allowPath = Path.Combine(TempDir.FullName, "benine.txt");
        File.WriteAllText(allowPath, "Regular text.");
    }

    public void Dispose()
    {
        TempDir.Delete(true);
    }

    [Fact]
    public void SmartTextCheckerTest()
    {
        var writer = new StringWriter();
        ISmartTextReader _reader = new SmartTextReader();
        ISmartTextReader reader = new SmartTextChecker(_reader, writer);

        string path = Path.Combine(TempDir.FullName, "hello.txt");
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
        Assert.Equal(expectedOutput, writer.GetStringBuilder().ToString().Split(Environment.NewLine));
    }

    [Fact]
    public void SmartTextReaderLocker()
    {
        ISmartTextReader _reader = new SmartTextReader();
        ISmartTextReader reader = new SmartTextReaderLocker(_reader, [new Regex("secret.*")]);

        var blockPath = Path.Combine(TempDir.FullName, "secret.txt");
        char[][] text1 = reader.ReadText(blockPath);
        Assert.Empty(text1);

        var allowPath = Path.Combine(TempDir.FullName, "benine.txt");
        char[][] text2 = reader.ReadText(allowPath);
        Assert.Equal("Regular text.", new string(text2[0]));
    }
}