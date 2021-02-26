using System;

namespace Chapter_06___The_Command_Pattern.Recievers
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door is opening");
        }
        
        public void Down()
        {
            Console.WriteLine("Garage Door is closing");
        }
    }
}