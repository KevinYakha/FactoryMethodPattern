﻿namespace FactoryMethodPattern
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
            Console.WriteLine($"The {this} attacks the {target} with its fists for 5 damage");
        }

        public override void attack(Mob target, Item weapon)
        {
            target.health -= weapon.getAttribute();
            Console.WriteLine($"The {this} attacks the {target} with its {weapon} for {weapon.getAttribute()} damage.");
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
