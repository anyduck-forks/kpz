using Lab3.Task5.States;

namespace Lab3.Task5.Nodes;

public class RadioButtonElement : LightElementNode
{
    private IRadioButtonState state;

    public LightElementNode Form;

    public string Name;
    public string Value;

    public RadioButtonElement(LightElementNode form, string name, string value, bool isChecked = false)
        : base("input", DisplayType.Inline, ClosingType.Single)
    {
        Attributes["type"] = "radio";
        Name = Attributes["name"] = name;
        Value = Attributes["value"] = value;
        Form = form;

        state = isChecked ? new SelectedState() : new DeselectedState();
    }

    public void ChangeState(IRadioButtonState state)
    {
        this.state = state;
    }

    public void Click()
    {
        state.Click(this);
    }

    public bool IsChecked => state.IsChecked;
}
