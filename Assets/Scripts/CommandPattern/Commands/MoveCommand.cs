namespace CommandPattern.Commands
{
    public class MoveCommand : Command
    {
        private MovementController _controller;
        private float _xDelta;
        private float _yDelta;
        
        public MoveCommand(MovementController controller, 
            float xDelta, float yDelta)
        {
            _controller = controller;
            _xDelta = xDelta;
            _yDelta = yDelta;
        }
        public override void Execute()
        {
            _controller.Move(_xDelta,_yDelta);
        }
        public override void Undo()
        {
            _controller.Move(-_xDelta,-_yDelta);
        }
    }
}