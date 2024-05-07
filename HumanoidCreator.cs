namespace FactoryMethodPattern
{
    public abstract class HumanoidCreator : MobCreator<HumanoidType>
    {
        protected override abstract Humanoid mobFactory(HumanoidType humanoidType);
        public Humanoid createHumanoid(HumanoidType humanoidType)
        {
            return mobFactory(humanoidType);
        }
    }
}
