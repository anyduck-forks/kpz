namespace Lab3.Task1;


public class FileWriter
{
    private readonly string _filePath;

    public FileWriter(string filePath)
    {
        _filePath = filePath;
    }

    public void Write(string message)
    {
        File.WriteAllText(_filePath, message);
    }

    public void WriteLine(string message)
    {
        File.AppendAllText(_filePath, message + Environment.NewLine);
    }
}