namespace FactoryMethodPattern
{
    public class Shield : Item
    {
        public int defenseValue { get; set; }

        public Shield(int defenseValue)
        {
            this.name = "Shield";
            this.id = (int)ItemType.Shield;
            this.defenseValue = defenseValue;
        }

        public override void useItem()
        {
            Console.WriteLine($"You defend yourself with your shield, mitigating {defenseValue} damage.");
        }
    }
}
