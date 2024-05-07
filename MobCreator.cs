namespace FactoryMethodPattern
{
    public abstract class MobCreator<TEnum> where TEnum : Enum
    {
        protected abstract Mob mobFactory(TEnum mobType);

        public Mob createMob(TEnum mobType)
        {
            return mobFactory(mobType);
        }
    }
}
