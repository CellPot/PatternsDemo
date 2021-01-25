namespace CommandPattern.Commands
{
    public class FireCommand : Command
    {
        private Player _player;
        public FireCommand(Player player)
        {
            _player = player;
        }
        public override void Execute()
        {
            _player.Fire();
        }
        public override void Undo()
        {
            _player.UnFire();
        }
    }

   
}