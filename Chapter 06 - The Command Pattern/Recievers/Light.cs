using System;

namespace Chapter_06___The_Command_Pattern.Recievers
{
    public class Light
    {
        private readonly string _place;

        public Light(string place)
        {
            _place = place;
        }
        
        public void On()
        {
            Console.WriteLine($"Light on {_place} is on!");
        }
        
        public void Off()
        {
            Console.WriteLine($"Light on {_place} is off!");
        }
    }
}