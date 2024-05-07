namespace FactoryMethodPattern
{
    public class Player
    {
        private static readonly Player player = new Player();

        public Inventory inventory = new Inventory();
        public int health;

        private Player() {}

        public static Player getInstance()
        {
            return player;
        }
    }
}
