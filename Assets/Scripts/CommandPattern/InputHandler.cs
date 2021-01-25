using CommandPattern.Commands;
using UnityEngine;

namespace CommandPattern
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] private MovementController controller;
        [SerializeField] private Player player;
        private Command buttonMouse0;
        private Command buttonMouse1;

        private void Awake()
        {
            buttonMouse0 = new MoveCommand(controller, 1f, 1f);
            buttonMouse1 = new FireCommand(player);
        }

        private void Update()
        {
            HandleInput();
        }

        private void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                buttonMouse0.Execute();
            }
            else if (Input.GetKeyDown(KeyCode.U))
            {
                buttonMouse0.Undo();
            }

            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                buttonMouse1.Execute();
            }
        }
    }
}