using System;

namespace Chapter_10___The_State_Pattern.States
{
    public class SoldState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrack()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }

        public void Dispense()
        {
            
            _gumballMachine.ReleaseBall();
            _gumballMachine.State =
                _gumballMachine.Count > 0 ? _gumballMachine.NoQuarterState : _gumballMachine.SoldOutState;
        }

        public override string ToString()
        {
            return "waiting to dispense the gumball";
        }
        
        public void Refill()
        {
            Console.WriteLine("Cannot refill");
        }
    }
}