using Lab3.Task1;
using Lab3.Task1.Loggers;
using Xunit;

namespace Lab3.Task1.Tests;


public class AdaptersTests
{
    [Fact]
    public void FileLoggerAdapter()
    {
        var path = Path.GetTempFileName();
        try
        {
            ILogger logger = new FileLoggerAdapter(new FileWriter(path));
        
            logger.Log("Test log message");
            logger.Error("Test error message");
            logger.Warn("Test warn message");

            string[] lines = File.ReadAllLines(path);
            Assert.Equal(3, lines.Length);
            Assert.Equal("Log: Test log message", lines[0]);
            Assert.Equal("Error: Test error message", lines[1]);
            Assert.Equal("Warn: Test warn message", lines[2]);
        }
        finally
        {
            File.Delete(path);
        }
    }
}
