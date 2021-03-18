using System;

namespace Chapter_10___The_State_Pattern.States
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        
        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.State = _gumballMachine.HasQuarterState;
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrack()
        {
            Console.WriteLine("You turned, but there is no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public override string ToString()
        {
            return "waiting for a quarter";
        }
        
        public void Refill()
        {
            Console.WriteLine("Cannot refill");
        }
    }
}