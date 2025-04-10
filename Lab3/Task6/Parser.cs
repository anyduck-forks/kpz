using Lab3.Task6.Nodes;

namespace Lab3.Task6;

class Parser
{
    static public LightElementNode Parse(TextReader reader)
    {
        LightElementNode root = new LightElementNode(ElementTypeFactory.GetElementType("html"));
        string line = reader.ReadLine() ?? string.Empty;

        LightElementNode element = new LightElementNode(
            ElementTypeFactory.GetElementType("h1", fontSize: 32, fontWeight: 700, margin: (0, 20, 0, 10))
        );
        element.AddChild(new LightTextNode(line));
        root.AddChild(element);

        while ((line = reader.ReadLine()) != null)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            if (line.Length < 20)
            {
                element = new LightElementNode(
                    ElementTypeFactory.GetElementType("h2", fontSize: 28, fontWeight: 700, margin: (0, 20, 0, 10))
                );
            }
            else if (line.StartsWith(' '))
            {
                element = new LightElementNode(
                    ElementTypeFactory.GetElementType("blockquote", fontWeight: 400, padding: (20, 0, 0, 0))
                );
            }
            else
            {
                element = new LightElementNode(
                    ElementTypeFactory.GetElementType("p")
                );
            }
            element.AddChild(new LightTextNode(line));
            root.AddChild(element);
        }

        return root;
    }
}
