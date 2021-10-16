using System;
using System.Collections.Generic;

namespace Gilded_rose
{
    public class GildedRose
    {
        public IList<Item> Items;
<<<<<<< HEAD
        private readonly ItemFactory itemFactory = new ItemFactory();
=======
        private ItemFactory itemFactory = new ItemFactory();
>>>>>>> main

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }
        

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
<<<<<<< HEAD
                itemFactory.CreateItem(item.Name).UpdateStatus(item);
=======
                itemFactory.CreateItem(item.Name).UpdateQuality(item);
>>>>>>> main
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