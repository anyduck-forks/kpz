namespace Lab3.Task4;

public class SmartTextReader : ISmartTextReader
{
    public char[][] ReadText(string filePath)
    {
        List<char[]> result = [];
        foreach (var line in  File.ReadLines(filePath))
        {
            result.Add(line.ToCharArray());
        }
        return result.ToArray();
    }
}