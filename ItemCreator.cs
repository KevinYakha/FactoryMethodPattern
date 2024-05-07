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

        public Item createRandomItem(int attributeMin, int attributeMax)
        {
            Random random = new Random(DateTime.Now.Microsecond);

            ItemType randomType = (ItemType)random.Next((int)ItemType.COUNT);
            int randomAttribute = random.Next(attributeMin, attributeMax + 1);

            Item randomItem = itemFactory(randomType, randomAttribute);
            randomItem.useItem();

            return randomItem;
        }

        public Item createRandomItem()
        {
            return createRandomItem(10, 30);
        }
    }
}
