using System;

namespace Chapter_10___The_State_Pattern.States
{
    public class WinnerState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
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
            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.State = _gumballMachine.SoldOutState;
                return;
            }
            
            _gumballMachine.ReleaseBall();
            Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
            _gumballMachine.State =
                _gumballMachine.Count > 0 ? _gumballMachine.NoQuarterState : _gumballMachine.SoldOutState;
        }

        public override string ToString()
        {
            return "Rewarding the winner with 2 gumballs";
        }
        
        public void Refill()
        {
            Console.WriteLine("Cannot refill");
        }
    }
}