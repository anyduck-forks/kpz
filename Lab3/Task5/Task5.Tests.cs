using Lab3.Task5.Commands;
using Lab3.Task5.Nodes;
using Xunit;

namespace Lab3.Task5.Tests;

public class LightHTMLTests
{
    [Fact]
    public void HTMLTest()
    {
        var html = CreateSampleHTML();
        string expectedInnerHTML = """<li>Item 1</li><li>Item 2</li><ul>Item 3<li><img src="image.jpg"></li></ul>""";
        Assert.Equal(expectedInnerHTML, html.InnerHTML);
        Assert.Equal($"<ul>{expectedInnerHTML}</ul>", html.OuterHTML);
    }

    [Fact]
    public void IteratorTest()
    {
        var html = CreateSampleHTML();

        var traversedOutput = new List<string>();
        foreach (var node in html)
        {
            if (node is LightTextNode textNode)
            {
                traversedOutput.Add(textNode.Text);
            }
            else if (node is LightElementNode elementNode)
            {
                traversedOutput.Add(elementNode.TagName);
            }
        }

        var expectedOutput = new[] { "ul", "li", "Item 1", "li", "Item 2", "ul", "Item 3", "li", "img" };
        Assert.Equal(expectedOutput, traversedOutput);
    }

    [Fact]
    public void AddChildCommand()
    {
        var parent = new LightElementNode("div");
        var child = new LightTextNode("Hello");
        var command = new AddChildCommand(parent, child);

        command.Execute();
        Assert.Single(parent.Children);
        Assert.Same(child, parent.Children[0]);

        command.Undo();
        Assert.Empty(parent.Children);
    }

    [Fact]
    public void SetAttributeCommand()
    {
        var node = new LightElementNode("img");
        var command = new SetAttributeCommand(node, "src", "img.png");

        command.Execute();
        Assert.Equal("img.png", node.Attributes["src"]);

        command.Undo();
        Assert.False(node.Attributes.ContainsKey("src"));
    }

    [Fact]
    public void CommandManager()
    {
        var invoker = new CommandManager();
        var parent = new LightElementNode("div");
        var child1 = new LightTextNode("First");
        var child2 = new LightTextNode("Second");

        var command1 = new AddChildCommand(parent, child1);
        var command2 = new AddChildCommand(parent, child2);


        invoker.Execute(command1);
        invoker.Execute(command2);
        Assert.Equal(2, parent.Children.Count);
        Assert.Same(child1, parent.Children[0]);
        Assert.Same(child2, parent.Children[1]);


        invoker.UndoLast();
        Assert.Single(parent.Children);
        Assert.Same(child1, parent.Children[0]);

        invoker.UndoLast();
        Assert.Empty(parent.Children);
    }

    [Fact]
    public void RadioButton_Click_ShouldToggleState()
    {
        var form = new LightElementNode("form");
        var radioButton = new RadioButtonElement(form, "color", "red", false);

        radioButton.Click();
        Assert.True(radioButton.IsChecked);

        radioButton.Click();
        Assert.False(radioButton.IsChecked);
    }
    
    [Fact]
    public void RadioButton_DifferentGroups_ShouldNotAffectEachOther()
    {
        var form = new LightElementNode("form");
        var colorRadio1 = new RadioButtonElement(form, "color", "red", false);
        var colorRadio2 = new RadioButtonElement(form, "color", "green", false);
        var sizeRadio1 = new RadioButtonElement(form, "size", "small", false);
        var sizeRadio2 = new RadioButtonElement(form, "size", "large", false);
        form.AddChild(colorRadio1);
        form.AddChild(colorRadio2);
        form.AddChild(sizeRadio1);
        form.AddChild(sizeRadio2);
        
        colorRadio1.Click();
        sizeRadio1.Click();
        Assert.True(colorRadio1.IsChecked);
        Assert.False(colorRadio2.IsChecked);
        Assert.True(sizeRadio1.IsChecked);
        Assert.False(sizeRadio2.IsChecked);
        
        colorRadio2.Click();
        Assert.False(colorRadio1.IsChecked);
        Assert.True(colorRadio2.IsChecked);
        Assert.True(sizeRadio1.IsChecked);
        Assert.False(sizeRadio2.IsChecked);
    }

    private LightElementNode CreateSampleHTML()
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

        return ul;
    }
}