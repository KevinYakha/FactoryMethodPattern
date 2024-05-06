namespace FactoryMethodPattern
{
    public class Shield : Item
    {
        public int defenseValue { get; set; }

        public Shield(int defenseValue)
        {
            Random random = new Random();

            this.name = "Shield";
            this.id = random.Next(DateTime.Now.Microsecond);
            this.defenseValue = defenseValue;
        }

        public override void useItem()
        {
            Console.WriteLine($"You defend yourself with your shield, mitigating {defenseValue} damage.");
        }
    }
}
