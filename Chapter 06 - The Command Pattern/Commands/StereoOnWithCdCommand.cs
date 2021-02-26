using Chapter_06___The_Command_Pattern.Recievers;

namespace Chapter_06___The_Command_Pattern.Commands
{
    public class StereoOnWithCdCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        
        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            _stereo.Off();
        }

        string ICommand.ToString()
        {
            return "StereoOnWithCdCommand";
        }
    }
}