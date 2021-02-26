using Chapter_06___The_Command_Pattern.Recievers;

namespace Chapter_06___The_Command_Pattern.Commands
{
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }
        
        string ICommand.ToString()
        {
            return "StereoOffCommand";
        }
    }
}