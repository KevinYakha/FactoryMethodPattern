namespace FactoryMethodPattern
{
    public abstract class Mob
    {
        public int health;

        public abstract string getDescription();
        public abstract void attack(Mob target);
    }
}
