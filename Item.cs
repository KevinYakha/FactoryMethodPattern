namespace FactoryMethodPattern
{
    public abstract class Item
    {
        public string name { get; set; }
        public int id { get; set; }

        public abstract void useItem();
    }
}
