using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter_06___The_Command_Pattern.Commands;

namespace Chapter_06___The_Command_Pattern.Invokers
{
    public class RemoteControl
    {
        private readonly List<ICommand> _onCommands;
        private readonly List<ICommand> _offCommands;
        private ICommand _lastCommand = new NoCommand();

        public RemoteControl(int totalSlots)
        {
            _offCommands = new List<ICommand>(Enumerable.Repeat(new NoCommand(), 7).ToList());
            _onCommands = new List<ICommand>(Enumerable.Repeat(new NoCommand(), 7).ToList());
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonPressed(int slot)
        {
            _onCommands[slot].Execute();
            _lastCommand = _onCommands[slot];
        }
        
        public void OffButtonPressed(int slot)
        {
            _offCommands[slot].Execute();
            _lastCommand = _onCommands[slot];
        }

        public void UndoButtonPressed()
        {
            _lastCommand.Undo();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("--------- Remote Control ---------\n");
            for (var i = 0; i < _offCommands.Count; i++)
            {
                sb.Append($"[Slot {i}] {_onCommands[i].ToString()} {_offCommands[i].ToString()}\n");
            }

            return sb.ToString();
        }
    }
}