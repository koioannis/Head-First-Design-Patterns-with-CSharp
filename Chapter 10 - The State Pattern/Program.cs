using System;
using Chapter_10___The_State_Pattern.States;

namespace Chapter_10___The_State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var gumballMachine = new GumballMachine(5);
            var state = new HasQuarterState(gumballMachine);
            
            Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrack();
            
            Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrack();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrack();
            
            Console.WriteLine(gumballMachine);
        }
    }
}