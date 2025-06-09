namespace Lab3.Task5.Commands;

public interface ICommand
{
    void Execute();
    void Undo();
}
