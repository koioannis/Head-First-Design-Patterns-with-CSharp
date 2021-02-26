using System;

namespace Chapter_06___The_Command_Pattern.Recievers
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo is on");
        }
        
        public void Off()
        {
            Console.WriteLine("Stereo is off");
        }
        
        public void SetCd()
        {
            Console.WriteLine("Stereo is set to CD mode");
        }
        
        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume is set to {volume}");
        }
    }
}