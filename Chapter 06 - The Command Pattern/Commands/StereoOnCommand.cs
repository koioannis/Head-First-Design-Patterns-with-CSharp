using Chapter_06___The_Command_Pattern.Recievers;

namespace Chapter_06___The_Command_Pattern.Commands
{
    public class StereoOnCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        
        public void Execute()
        {
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }

        string ICommand.ToString()
        {
            return "StereoOnCommand";
        }
    }
}