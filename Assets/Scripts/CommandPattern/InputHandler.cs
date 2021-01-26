using CommandPattern.Commands;
using UnityEngine;

namespace CommandPattern
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] private MovementController controller;
        [SerializeField] private Player player;
        private CommandsNavigator _commandsNav;
        private Command _keyMouse0;
        private Command _keyMouse1;
        private Command _keySpace;

        private void Awake()
        {
            _commandsNav = new CommandsNavigator();
            _keyMouse0 = new MoveCommand(controller, 1f, 1f);
            _keyMouse1 = new FireCommand(player);
            _keySpace = new DoNothingCommand();
        }
        private void Update()
        {
            HandleInput();
        }
        private void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
                ExecuteNewCommand(_keyMouse0);
            if (Input.GetKeyDown(KeyCode.Mouse1))
                ExecuteNewCommand(_keyMouse1);
            if (Input.GetKeyDown(KeyCode.Space))
                ExecuteNewCommand(_keySpace);
            if (Input.GetKeyDown(KeyCode.P))
                SwapKeyBinding(ref _keyMouse0,ref _keyMouse1);
            if (Input.GetKeyDown(KeyCode.Z))
            {
                _commandsNav.UndoPreviousCommand();
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                _commandsNav.RedoNextCommand();
            }
        }
        private void ExecuteNewCommand(Command command)
        {
            command.Execute();
            _commandsNav.AddToUndo(command);
            _commandsNav.ClearRedo();
        }
        private void SwapKeyBinding(ref Command key1, ref Command key2)
        {
            Command temp = key1;
            key1 = key2;
            key2 = temp;
        }
    }
}