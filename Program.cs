namespace FactoryMethodPattern
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ItemCreator inventory = new itemBuilder();
            Item hammer = inventory.createItem(ItemType.Hammer, 20);

            Console.ReadKey();
        }
    }
}
