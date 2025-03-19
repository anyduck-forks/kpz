using System.Text.RegularExpressions;

namespace Lab3.Task4;

public class SmartTextReaderLocker(ISmartTextReader reader, ICollection<Regex> blocklist) : ISmartTextReader
{
    private readonly ISmartTextReader _reader = reader;
    private readonly ICollection<Regex> _blocklist = blocklist;

    public char[][] ReadText(string filePath)
    {

        foreach (var regex in _blocklist)
        {
            if (regex.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return Array.Empty<char[]>();
            }
        }

        return _reader.ReadText(filePath);
    }
}