using System;
using System.Collections.Generic;
using Chapter_06___The_Command_Pattern.Commands;
using Chapter_06___The_Command_Pattern.Invokers;
using Chapter_06___The_Command_Pattern.Recievers;

namespace Chapter_06___The_Command_Pattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var light = new Light("Bedroom");
            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);

            var garageDoor = new GarageDoor();
            var garageDoorUpCommand = new GarageDoorUpCommand(garageDoor);
            var garageDoorDoorCommand = new GarageDoorDownCommand(garageDoor);

            var stereo = new Stereo();
            var stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);
            var stereoOffCommand = new StereoOffCommand(stereo);
            var stereoOnCommand = new StereoOnCommand(stereo);


            var macroCommand = new MacroCommand(new List<ICommand>
                {stereoOnCommand, garageDoorUpCommand, lightOnCommand});

            var remote = new RemoteControl(7);
            
            remote.SetCommand(0, lightOnCommand, lightOffCommand);
            remote.SetCommand(1, garageDoorUpCommand, garageDoorDoorCommand);
            remote.SetCommand(2, stereoOnWithCdCommand, stereoOffCommand);
            remote.SetCommand(2, macroCommand, macroCommand);
            
            // remote.OnButtonPressed(0);
            // remote.OffButtonPressed(0);
            //
            // remote.OnButtonPressed(1);
            //
            // remote.OnButtonPressed(2);
            remote.OnButtonPressed(2);
            remote.UndoButtonPressed();
            
            Console.WriteLine(remote.ToString());
        }
    }
}