

namespace FactoryMethodPattern
{
    internal class HumanoidBuilder : HumanoidCreator
    {
        protected override Humanoid mobFactory(HumanoidType humanoidType)
        {
            switch (humanoidType)
            {
                case HumanoidType.Human:
                    return new Human();
                case HumanoidType.Goblin:
                    return new Goblin();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
