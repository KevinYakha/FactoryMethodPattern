namespace FactoryMethodPattern
{
    public abstract class ItemCreator
    {
        protected abstract Item itemFactory(ItemType itemType, int attribute);

        public Item createItem(ItemType itemType, int attribute)
        {
            Item item = itemFactory(itemType, attribute);

            item.useItem();

            return item;
        }
    }
}
