using System;

namespace Chapter_05___The_Singleton_Pattern
{
    public sealed class ChocolateBoilerSingleton
    {
        private static readonly Lazy<ChocolateBoilerSingleton> Lazy =
            new Lazy<ChocolateBoilerSingleton>(() => new ChocolateBoilerSingleton());
        
        public static ChocolateBoilerSingleton Instance => Lazy.Value;

        private bool IsEmpty { get; set; }
        
        private bool IsBoiled { get; set; }

        private ChocolateBoilerSingleton()
        {
            IsEmpty = true;
            IsBoiled = false;
        }

        public void Fill()
        {
            if (!IsEmpty)
            {
                Console.WriteLine("Already filled!");
                return;
            }
            
            Console.WriteLine("Filling");
            
            IsEmpty = false;
            IsBoiled = false;
        }

        public void Drain()
        {
            if (!IsEmpty && IsBoiled)
                IsEmpty = true;
            
            Console.WriteLine("Draining");
        }

        public void Boil()
        {
            if (IsEmpty || IsBoiled) return;

            IsBoiled = true;
            Console.WriteLine("Boiling");
        }
    }
}