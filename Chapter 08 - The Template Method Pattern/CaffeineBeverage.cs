using System;

namespace Chapter_08___The_Template_Method_Pattern
{
    public abstract class CaffeineBeverage
    {
        // this is the template method
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourIntoCup();

            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();
        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PourIntoCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}