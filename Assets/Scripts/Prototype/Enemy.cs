
namespace Prototype
{
    public abstract class Enemy
    {
        protected int abilitiesNumber = 0;

        public Enemy() { }
        public Enemy(int abilitiesNumber)
        {
            this.abilitiesNumber = abilitiesNumber;
        }
        public abstract Enemy Clone();
        public abstract string GetDescription();

    }

}


