namespace FactoryMethodPattern
{
    public class Wolf : Creature
    {
        Wolf()
        {
            health = 20;
            attackValue = 15;
        }

        public override void attack(Mob target)
        {
            target.health -= attackValue;
        }

        public override string getDescription()
        {
            return "It is a wolf.";
        }

        public override string growl()
        {
            return "Awooo!";
        }
    }
}
