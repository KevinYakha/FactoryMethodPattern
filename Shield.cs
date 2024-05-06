namespace FactoryMethodPattern
{
    public class Shield : Item
    {
        public int defenseValue {  get; set; }

        public override void useItem()
        {
            Console.WriteLine($"You defend yourself with your shield, mitigating {defenseValue} damage.");
        }
    }
}
