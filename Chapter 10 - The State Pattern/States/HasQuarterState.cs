using System;

namespace Chapter_10___The_State_Pattern.States
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.State = _gumballMachine.NoQuarterState;
        }

        public void TurnCrack()
        {
            Console.WriteLine("You turned...");
            
            if (new Random().Next(0, 100) < 10)
            {
                _gumballMachine.State =
                    _gumballMachine.Count > 1 ? _gumballMachine.WinnerState : _gumballMachine.SoldState;

                return;
            }
            _gumballMachine.State = _gumballMachine.SoldState;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void Refill()
        {
            Console.WriteLine("Cannot refill");
        }

        public override string ToString()
        {
            return "waiting for the crack to be turned";
        }
    }
}