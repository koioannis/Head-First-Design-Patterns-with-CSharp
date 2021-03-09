using System;
using Chapter_07___The_Adapter_and_Facade_Patterns.The_Facade_Pattern;
using Chapter_07___The_Adapter_and_Facade_Patterns.The_Facade_Pattern.HomeTheater;

namespace Chapter_07___The_Adapter_and_Facade_Patterns
{
    public class HomeTheaterFacade
    {
        private Amplifier Amp;
        private Tuner Tuner;
        private Projector Projector;
        private TheaterLights Lights;
        private Screen Screen;
        private PopcornPopper Popper;
        private StreamingPlayer Player;

        public HomeTheaterFacade(PopcornPopper popper, Screen screen, TheaterLights lights, Projector projector, Tuner tuner, Amplifier amp, StreamingPlayer player)
        {
            Popper = popper;
            Screen = screen;
            Lights = lights;
            Projector = projector;
            Tuner = tuner;
            Amp = amp;
            Player = player;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie");
            
            Popper.On();
            Popper.Pop();
            Lights.Dim = 10;
            Screen.Down();
            Projector.On();
            Projector.WideScreenMode();
            Amp.On();
            Amp.Player = Player;
            Amp.SetStereoSound();
            Amp.Volume = 5;
            Player.On();
            Player.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            Popper.Off();
            Lights.On();
            Screen.Up();
            Projector.Off();
            Amp.Off();
            Player.Stop();
            Player.Off();
        }
        
    }
}