using Lab3.Task5.Nodes;

namespace Lab3.Task5.Commands;


public class CommandManager
{
    private readonly Stack<ICommand> history = new Stack<ICommand>();

    public void Execute(ICommand command)
    {
        command.Execute();
        history.Push(command);
    }

    public void UndoLast()
    {
        if (history.Count > 0)
        {
            ICommand command = history.Pop();
            command.Undo();
        }
    }
}
