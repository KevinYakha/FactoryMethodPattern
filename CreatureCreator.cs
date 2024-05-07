namespace FactoryMethodPattern
{
    public abstract class CreatureCreator : MobCreator<CreatureType>
    {
        protected override abstract Creature mobFactory(CreatureType creatureType);
        public Creature createCreature(CreatureType creatureType)
        {
            return mobFactory(creatureType);
        }
    }
}
