namespace FactoryMethodPattern
{
    public class itemBuilder : ItemCreator
    {
        protected override Item itemFactory(ItemType itemType, int attribute)
        {
            switch (itemType)
            {
                case ItemType.Hammer:
                    return new Hammer(attribute);
                case ItemType.Shield:
                    return new Shield(attribute);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
