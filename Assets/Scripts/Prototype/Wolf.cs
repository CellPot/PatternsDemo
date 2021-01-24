
namespace Prototype
{
    public class Wolf : Enemy
    {
        private bool isAgressive;

        public Wolf(bool isAgressive, int abilitiesNumber) : base(abilitiesNumber)
        {
            this.isAgressive = isAgressive;
        }

        public override Enemy Clone()
        {
            return new Wolf(this.isAgressive, this.abilitiesNumber);
        }
        public override string GetDescription()
        {
            return $"This is a wooof! Is it agressive? {isAgressive}. And it has {abilitiesNumber} abilities";
        }
    }

}


