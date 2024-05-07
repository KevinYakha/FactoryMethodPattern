namespace FactoryMethodPattern
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Player player = Player.getInstance();
            ItemCreator itemCreator = new itemBuilder();

            player.inventory.addItem(itemCreator.createItem(ItemType.Hammer, 30));

            HumanoidCreator humanoidCreator = new HumanoidBuilder();
            CreatureCreator creatureCreator = new CreatureBuilder();

            Human human = (Human)humanoidCreator.createHumanoid(HumanoidType.Human);
            Goblin goblin = (Goblin)humanoidCreator.createHumanoid(HumanoidType.Goblin);
            Wolf wolf = (Wolf)creatureCreator.createCreature(CreatureType.Wolf);

            human.inventory.addItem(itemCreator.createItem(ItemType.Hammer, 20));

            human.attack(wolf, human.inventory.inventory[0]);
            Console.WriteLine("wolf health: {0}", wolf.health);

            wolf.attack(goblin);
            Console.WriteLine("goblin health: {0}", goblin.health);

            goblin.attack(human);
            Console.WriteLine("human health: {0}", human.health);

            Console.ReadKey();
        }
    }
}
