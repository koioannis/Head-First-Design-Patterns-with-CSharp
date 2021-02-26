using Chapter_06___The_Command_Pattern.Recievers;

namespace Chapter_06___The_Command_Pattern.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            this._light = light;
        }
        
        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
        
        string ICommand.ToString()
        {
            return "LightOnCommand";
        }
    }
}