using Chapter_06___The_Command_Pattern.Recievers;

namespace Chapter_06___The_Command_Pattern.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            this._light = light;
        }
        
        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }

        string ICommand.ToString()
        {
            return "LightOffCommand";
        }
    }
}