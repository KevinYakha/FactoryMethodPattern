namespace FactoryMethodPattern
{
    public class Player : Humanoid 
    {
        private static readonly Player player = new Player();

        private Player()
        {
            health = 100;
        }

        public static Player getInstance()
        {
            return player;
        }

        public override string getDescription()
        {
            return "This is the player character";
        }

        public override string speak()
        {
            return "I am that guy!";
        }

        public override void attack(Mob target)
        {
            target.health -= 5;
        }
        
        public override void attack(Mob target, Item weapon)
        {
            target.health -= weapon.getAttribute();
        }
    }
}
