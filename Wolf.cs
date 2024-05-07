namespace FactoryMethodPattern
{
    public class Wolf : Creature
    {
        public Wolf()
        {
            health = 20;
            attackValue = 15;
        }

        public override void attack(Mob target)
        {
            target.health -= attackValue;
            Console.WriteLine($"The {this} attacks the {target} with its fangs for {attackValue} damage");
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
