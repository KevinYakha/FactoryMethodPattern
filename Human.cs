namespace FactoryMethodPattern
{
    public class Human : Humanoid
    {
        public Human()
        {
            health = 50;
        }

        public override void attack(Mob target)
        {
            target.health -= 5;
            Console.WriteLine($"The {this} attacks the {target} with their fists for 5 damage");
        }

        public override void attack(Mob target, Item weapon)
        {
            target.health -= weapon.getAttribute();
            Console.WriteLine($"The {this} attacks the {target} with their {weapon} for {weapon.getAttribute()} damage.");
        }

        public override string getDescription()
        {
            return "It is a Human";
        }

        public override string speak()
        {
            return "How may I be of assistance?";
        }
    }
}
