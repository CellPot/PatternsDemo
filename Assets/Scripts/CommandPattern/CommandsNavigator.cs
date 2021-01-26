using System.Collections.Generic;
using CommandPattern.Commands;
using UnityEngine;

namespace CommandPattern
{
    public class CommandsNavigator
    {
        private readonly Stack<Command> _undoCommands;
        private readonly Stack<Command> _redoCommands;

        public CommandsNavigator()
        {
            _undoCommands = new Stack<Command>();
            _redoCommands = new Stack<Command>();
        }
        public void UndoPreviousCommand()
        {
            if (_undoCommands.Count > 0)
            {
                Command previousCommand = _undoCommands.Pop();
                previousCommand.Undo();
                AddToRedo(previousCommand);
                Debug.Log("Undid the previous command");
            }
            else
                Debug.Log("At the start of command list");
        }
        public void AddToUndo(Command command)
        {
            _undoCommands.Push(command);
        }
        public void AddToRedo(Command command)
        {
            _redoCommands.Push(command);
        }
        public void ClearRedo()
        {
            _redoCommands.Clear();
        }
        public void RedoNextCommand()
        {
            if (_redoCommands.Count > 0)
            {
                Command nextCommand = _redoCommands.Pop();
                nextCommand.Execute();
                AddToUndo(nextCommand);
                Debug.Log("Redid the next command");
            }
            else
            {
                Debug.Log("At the end of command list");
            }
        }
    }
}