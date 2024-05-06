namespace FactoryMethodPattern
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ItemCreator inventory = new itemBuilder();

            Item random1 = inventory.createRandomItem();
            Item random2 = inventory.createRandomItem();
            Item random3 = inventory.createRandomItem();
            Item random4 = inventory.createRandomItem();
            Item random5 = inventory.createRandomItem();

            Console.ReadKey();
        }
    }
}
