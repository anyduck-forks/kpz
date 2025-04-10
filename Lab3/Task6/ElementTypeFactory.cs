namespace Lab3.Task6;

public class ElementTypeFactory
{
    private static Dictionary<string, ElementType> cache = new();

    public static ElementType GetElementType(
        string tagName,
        ClosingType closingType = ClosingType.Double,
        DisplayType displayType = DisplayType.Block,
        int fontSize = 16,
        int fontWeight = 400,
        (int, int, int, int) padding = default,
        (int, int, int, int) margin = default)
    {
        var key = (tagName, closingType, displayType, fontSize, fontWeight, padding, margin).ToString();

        if (cache.TryGetValue(key, out var existingElementLayout))
        {
            return existingElementLayout;
        }
        else
        {
            cache[key] = new ElementType(tagName, closingType, displayType, fontSize,
                fontWeight, padding, margin);
            return cache[key];
        }
    }
}