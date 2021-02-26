namespace Chapter_06___The_Command_Pattern.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();

        string ToString();
    }
}