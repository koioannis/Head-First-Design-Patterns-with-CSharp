namespace Chapter_05___The_Singleton_Pattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var instance1 = ChocolateBoilerSingleton.Instance;
            var instance2 = ChocolateBoilerSingleton.Instance;
            
            instance1.Fill();
            /* we can see that it is already filled,
             since instance 1 and instance2 share the same instance */
            instance2.Fill();
            
            instance2.Boil();
            
            instance1.Drain();
        }
    }
}