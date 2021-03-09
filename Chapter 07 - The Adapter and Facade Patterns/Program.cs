using System;
using Chapter_07___The_Adapter_and_Facade_Patterns.The_Adapter_Pattern.Adapters;
using Chapter_07___The_Adapter_and_Facade_Patterns.The_Adapter_Pattern.Duck;
using Chapter_07___The_Adapter_and_Facade_Patterns.The_Adapter_Pattern.Turkey;
using Chapter_07___The_Adapter_and_Facade_Patterns.The_Facade_Pattern;
using Chapter_07___The_Adapter_and_Facade_Patterns.The_Facade_Pattern.HomeTheater;

namespace Chapter_07___The_Adapter_and_Facade_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            The Adapter pattern
            
            var duck = new MallardDuck();

            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says...");
            turkey.Gobble();
            turkey.Fly();
            
            Console.WriteLine("The duck says...");
            TestDuck(duck);
            
            Console.WriteLine("The TurkeyAdaptor says...");
            TestDuck(turkeyAdapter);
            */
            
             /*
             The Facade Pattern
              
             var player = new StreamingPlayer();
             var popper = new PopcornPopper();
             var lights = new TheaterLights();
             var screen = new Screen();
             var projector = new Projector();
             var amp = new Amplifier();
             var tuner = new Tuner();

             var homeTheater = new HomeTheaterFacade(popper, screen, lights, projector, tuner, amp, player);
             
             homeTheater.WatchMovie("Star Wars");
             homeTheater.EndMovie();
            */

        }

        private static void TestDuck(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}