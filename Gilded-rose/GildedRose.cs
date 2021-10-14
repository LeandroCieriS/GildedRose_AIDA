using System;
using System.Collections.Generic;

namespace Gilded_rose
{
    public class GildedRose
    {
        public IList<Item> Items;
        private ItemFactory itemFactory = new ItemFactory();

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }
        

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                itemFactory.CreateItem(item.Name).UpdateQuality(item);
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
}