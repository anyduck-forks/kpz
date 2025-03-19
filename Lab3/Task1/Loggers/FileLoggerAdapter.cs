namespace Lab3.Task1.Loggers;

public class FileLoggerAdapter(FileWriter fileWriter) : ILogger
{
    private readonly FileWriter _fileWriter = fileWriter;

    public void Log(string message)
    {
        _fileWriter.WriteLine($"Log: {message}");
    }

    public void Error(string message)
    {
        _fileWriter.WriteLine($"Error: {message}");
    }

    public void Warn(string message)
    {
        _fileWriter.WriteLine($"Warn: {message}");
    }
}