namespace FactoryMethodPattern
{
    public class Hammer : Item
    {
        public int attackValue { get; set; }

        public override void useItem()
        {
            Console.WriteLine($"You attack with your hammer, dealing {attackValue} damage.");
        }
    }
}
