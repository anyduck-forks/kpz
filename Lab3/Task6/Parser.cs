using Lab3.Task6.Nodes;

namespace Lab3.Task6;

class Parser
{
    static public LightElementNode Parse(TextReader reader)
    {
        LightElementNode root = new LightElementNode("html", DisplayType.Block, ClosingType.Double) {};
        string line = reader.ReadLine() ?? string.Empty;

        LightElementNode element = new LightElementNode("h1", DisplayType.Block, ClosingType.Double) { FontSize = 32, FontWeight = 700, MarginTop = 20, MarginBottom = 10 };
        element.Children.Add(new LightTextNode(line));
        root.Children.Add(element);

        while ((line = reader.ReadLine()) != null)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            if (line.Length < 20)
            {
                element = new LightElementNode("h2", DisplayType.Block, ClosingType.Double) { FontSize = 28, FontWeight = 700, MarginTop = 20, MarginBottom = 10 };
            }
            else if (line.StartsWith(' '))
            {
                element = new LightElementNode("blockquote", DisplayType.Block, ClosingType.Double) { FontWeight = 400, PaddingLeft = 20 };
            }
            else
            {
                element = new LightElementNode("p", DisplayType.Block, ClosingType.Double) { };
            }
            element.Children.Add(new LightTextNode(line));
            root.Children.Add(element);
        }

        return root;
    }
}
