using Chapter_06___The_Command_Pattern.Recievers;

namespace Chapter_06___The_Command_Pattern.Commands
{
    public class GarageDoorDownCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Down();
        }

        public void Undo()
        {
            _garageDoor.Up();
        }

        string ICommand.ToString()
        {
            return "GarageDoorDownCommand";
        }
    }
}