namespace Lab3.Task4;

public class SmartTextChecker(ISmartTextReader reader, TextWriter? writer = null) : ISmartTextReader
{
    private readonly ISmartTextReader _reader = reader;
    private readonly TextWriter writer = writer ?? Console.Out;

    public char[][] ReadText(string filePath)
    {
        writer.WriteLine($"Opening file: {filePath}");
        char[][] text = _reader.ReadText(filePath);
        writer.WriteLine($"File {filePath} read successfully.");

        int lines = text.Length;
        int characters = text.Sum(line => line.Length);

        writer.WriteLine($"Total lines: {lines}, Total characters: {characters}");
        writer.WriteLine($"Closing file: {filePath}");

        return text;
    }
}