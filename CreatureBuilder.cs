namespace FactoryMethodPattern
{
    public class CreatureBuilder : CreatureCreator
    {
        protected override Creature mobFactory(CreatureType creatureType)
        {
            switch (creatureType)
            {
                case CreatureType.Wolf:
                    return new Wolf();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
