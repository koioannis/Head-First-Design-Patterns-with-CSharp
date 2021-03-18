using System;
using Chapter_10___The_State_Pattern.States;

namespace Chapter_10___The_State_Pattern
{
    public class GumballMachine
    {
        public IState SoldOutState { get; }
        public IState HasQuarterState { get; }
        public IState SoldState { get; } 
        public IState NoQuarterState { get; }
        public IState WinnerState { get; }
        public IState State { get; set; }
        public int Count { get; set; }

        public GumballMachine(int numberOfGumballs)
        {
            SoldOutState = new SoldOutState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            NoQuarterState = new NoQuarterState(this);
            WinnerState = new WinnerState(this);

            Count = numberOfGumballs;
            State = Count > 0 ? NoQuarterState : SoldOutState;
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }
        
        public void EjectQuarter()
        {
            State.EjectQuarter();
        }
        
        
        public void TurnCrack()
        {
            State.TurnCrack();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            if (!(typeof(HasQuarterState) == HasQuarterState.GetType()))
            {
                return;
            }
            
            Console.WriteLine("A gumball comes rolling out the slot");
            if (Count > 0)
            {
                Count -= 1;
            }
        }

        public void Refill(int count)
        {
            Count += count;
            Console.WriteLine($"The gumball machine was just refilled; its new count is {Count}");
            State.Refill();
        }

        public override string ToString()
        {
            return "\nMighty Gumball Inc.\n" +
                   "Java-enabled Standing Gumball Model #2004\n" +
                   $"Inventory: {Count} Gumballs\n" +
                   $"Machine is {State.ToString()}\n";

        }
    }
}