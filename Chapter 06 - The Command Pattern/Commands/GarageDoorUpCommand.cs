using Chapter_06___The_Command_Pattern.Recievers;

namespace Chapter_06___The_Command_Pattern.Commands
{
    public class GarageDoorUpCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        
        public void Execute()
        {
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.Down();
        }

        string ICommand.ToString()
        {
            return "GarageDoorUpCommand";
        }
    }
}