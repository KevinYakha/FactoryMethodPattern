namespace FactoryMethodPattern
{
    public abstract class Creature : Mob
    {
        public int attackValue;

        public abstract string growl();
    }
}
