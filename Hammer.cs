namespace FactoryMethodPattern
{
    public class Hammer : Item
    {
        public int attackValue { get; set; }

        public Hammer(int attackValue)
        {
            this.name = "Hammer";
            this.id = (int)ItemType.Hammer;
            this.attackValue = attackValue;
        }

        public override void useItem()
        {
            Console.WriteLine($"You attack with your hammer, dealing {attackValue} damage.");
        }
    }
}
