using Lab3.Task5.Nodes;

namespace Lab3.Task5.States;

public interface IRadioButtonState
{
    void Click(RadioButtonElement radioButton);
    bool IsChecked { get; }
}

public class SelectedState : IRadioButtonState
{
    public bool IsChecked => true;

    public void Click(RadioButtonElement radioButton)
    {
        radioButton.ChangeState(new DeselectedState());
    }
}

public class DeselectedState : IRadioButtonState
{
    public bool IsChecked => false;

    public void Click(RadioButtonElement radio)
    {
        foreach (var element in radio.Form)
        {
            if (element is RadioButtonElement otherRadio && otherRadio.Name == radio.Name && otherRadio.IsChecked)
            {
                otherRadio.ChangeState(new DeselectedState());
            }
        }
        radio.ChangeState(new SelectedState());
    }
}
