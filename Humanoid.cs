namespace FactoryMethodPattern
{
    public abstract class Humanoid : Mob
    {
        public Inventory inventory = new Inventory();

        public abstract void attack(Mob target, Item weapon);
        public abstract string speak();
    }
}
