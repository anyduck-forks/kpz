namespace Lab3.Task4;

public class SmartTextChecker(ISmartTextReader reader, TextWriter? output) : ISmartTextReader
{
    private readonly ISmartTextReader _reader = reader;
    private readonly TextWriter _output = output ?? Console.Out;

    public char[][] ReadText(string filePath)
    {
        _output.WriteLine($"Opening file: {filePath}");
        char[][] text = _reader.ReadText(filePath);
        _output.WriteLine($"File {filePath} read successfully.");

        int lines = text.Length;
        int characters = text.Sum(line => line.Length);

        _output.WriteLine($"Total lines: {lines}, Total characters: {characters}");
        _output.WriteLine($"Closing file: {filePath}");

        return text;
    }
}