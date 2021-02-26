namespace Chapter_06___The_Command_Pattern.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            
        }

        public void Undo()
        {
            
        }
        
        string ICommand.ToString()
        {
            return "NoCommand";
        }
    }
}