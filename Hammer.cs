namespace FactoryMethodPattern
{
    public class Hammer : Item
    {
        public int attackValue { get; set; }

        public Hammer(int attackValue)
        {
            Random random = new Random();

            this.name = "Hammer";
            this.id = random.Next(DateTime.Now.Microsecond);
            this.attackValue = attackValue;
        }

        public override void useItem()
        {
            Console.WriteLine($"You attack with your hammer, dealing {attackValue} damage.");
        }

        public override int getAttribute()
        {
            return attackValue;
        }
    }
}
