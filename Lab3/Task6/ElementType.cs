namespace Lab3.Task6;

public enum DisplayType
{
    Block,
    Inline,
    InlineBlock,
    Flex,
    Grid,
    None
}

public enum ClosingType
{
    Single,
    Double
}

public class ElementType(
    string tagName,
    ClosingType closingType,
    DisplayType displayType,
    int fontSize,
    int fontWeight,
    (int, int, int, int) padding,
    (int, int, int, int) margin)
{
    public string TagName { get; } = tagName;
    public ClosingType ClosingType { get; } = closingType;
    public DisplayType DisplayType { get; } = displayType;
    public int FontSize { get; } = fontSize;
    public int FontWeight { get; } = fontWeight;
    public (int, int, int, int) Padding { get; } = padding;
    public (int, int, int, int) Margin { get; } = margin;
}