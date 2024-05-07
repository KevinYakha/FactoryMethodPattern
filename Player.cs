namespace FactoryMethodPattern
{
    public class Player
    {
        private static readonly Player player = new Player();

        public int health;
        private List<Item> inventory { get; } = new List<Item>();

        private Player() {}

        public static Player getInstance()
        {
            return player;
        }

        public void addItemToInventory(Item item)
        {
            inventory.Add(item);
        }

        public void removeItemFromInventory(int id)
        {
            inventory.RemoveAt(inventory.FindIndex(x => x.id == id));
        }

        public void removeItemFromInventory(Item item)
        {
            inventory.Remove(item);
        }
    }
}
