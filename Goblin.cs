namespace FactoryMethodPattern
{
    public class Goblin : Humanoid
    {
        public Goblin()
        {
            health = 25;
        }
        public override void attack(Mob target)
        {
            target.health -= 5;
        }

        public override void attack(Mob target, Item weapon)
        {
            target.health -= weapon.getAttribute();
        }

        public override string getDescription()
        {
            return "It is a goblin.";
        }

        public override string speak()
        {
            return "Grumble, grumble...";
        }
    }
}
