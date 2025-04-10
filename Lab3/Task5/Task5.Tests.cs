using Lab3.Task5.Nodes;
using Xunit;

namespace Lab3.Task5.Tests;

public class CompositeTests
{
    [Fact]
    public void LightHTMLTest()
    {
        var ul = new LightElementNode("ul", DisplayType.Block, ClosingType.Double);
    
        var li1 = new LightElementNode("li", DisplayType.Block, ClosingType.Double);
        li1.AddChild(new LightTextNode("Item 1"));
        ul.AddChild(li1);
    
        var li2 = new LightElementNode("li", DisplayType.Block, ClosingType.Double);
        li2.AddChild(new LightTextNode("Item 2"));
        ul.AddChild(li2);

        var ul2 = new LightElementNode("ul", DisplayType.Block, ClosingType.Double);
        ul2.AddChild(new LightTextNode("Item 3"));
        var li3 = new LightElementNode("li", DisplayType.Block, ClosingType.Double);
        var img = new LightElementNode("img", DisplayType.Block, ClosingType.Single);
        img.Attributes.Add("src", "image.jpg");
        li3.AddChild(img);
        ul2.AddChild(li3);
        ul.AddChild(ul2);

        string expectedInnerHTML = """<li>Item 1</li><li>Item 2</li><ul>Item 3<li><img src="image.jpg"></li></ul>""";
        Assert.Equal(expectedInnerHTML, ul.InnerHTML);
        Assert.Equal($"<ul>{expectedInnerHTML}</ul>", ul.OuterHTML);
    }
}