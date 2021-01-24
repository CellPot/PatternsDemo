
namespace Prototype
{
    public class Bee : Enemy
    {
        private bool isTalkative;

        public Bee(bool isTalkative)
        {
            this.isTalkative = isTalkative;
        }

        public override Enemy Clone()
        {
            return new Bee(this.isTalkative);
        }

        public override string GetDescription()
        {
            return $"This is a bzzzt! Sometimes it's talkative. " +
                $"Are you right to assume so? {isTalkative}. " +
                $"And it always has {abilitiesNumber} abilities!";
        }
    }

}


