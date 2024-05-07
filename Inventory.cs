namespace FactoryMethodPattern
{
    public class Inventory
    {
        public List<Item> inventory = new List<Item>();

        public void addItem(Item item)
        {
            inventory.Add(item);
        }

        public void removeItem(int id)
        {
            inventory.RemoveAt(inventory.FindIndex(x => x.id == id));
        }

        public void removeItem(Item item)
        {
            inventory.Remove(item);
        }
    }
}
