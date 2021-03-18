namespace Chapter_10___The_State_Pattern.States
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrack();
        void Dispense();

        void Refill();
    }
}