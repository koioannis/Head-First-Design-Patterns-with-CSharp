using System;
using System.Collections.Generic;

namespace Chapter_06___The_Command_Pattern.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly List<ICommand> _commands;

        public MacroCommand(List<ICommand> commands)
        {
            _commands = commands;
        }
        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }

        string ICommand.ToString()
        {
            return "MacroCommand";
        }
    }
}