#nullable enable
using System;

namespace Chapter_07___The_Adapter_and_Facade_Patterns.The_Facade_Pattern.HomeTheater
{
    public class StreamingPlayer
    {
        private Amplifier Amplifier;
        
        public void On()
        {
            Console.WriteLine($"{ToString()} is on");
        }
        
        public void Off()
        {
            Console.WriteLine($"{ToString()} is off");
        }
        
        public void Pause()
        {
            Console.WriteLine("Pausing movie");
        }
        
        public void Play(string movie)
        {
            Console.WriteLine($"Playing {movie}");
        }

        public void SetSurroundAudio()
        {
            throw new NotImplementedException();
        }

        public void SetTwoChannelAudio()
        {
            throw new NotImplementedException();
        }
        
        public void Stop()
        {
            Console.WriteLine($"{ToString()} is stopped");
        }

        public override string? ToString()
        {
            return "Player";
        }
    }
}