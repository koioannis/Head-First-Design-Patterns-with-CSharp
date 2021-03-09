#nullable enable
using System;

namespace Chapter_07___The_Adapter_and_Facade_Patterns.The_Facade_Pattern.HomeTheater
{
    public class Tuner
    {
        private Amplifier Amplifier;

        public void On()
        {
            throw new NotImplementedException();
        }
        
        public void Off()
        {
            throw new NotImplementedException();
        }
        
        public void SetAm()
        {
            throw new NotImplementedException();
        }
        
        public void SetFm()
        {
            throw new NotImplementedException();
        }
        
        public void SetFrequency()
        {
            throw new NotImplementedException();
        }
        
        public override string? ToString()
        {
            return GetType().Name;
        }
    }
}