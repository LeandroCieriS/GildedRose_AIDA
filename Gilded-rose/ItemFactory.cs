using System;
using System.Collections.Generic;

namespace Gilded_rose
{
    internal class ItemFactory
    {
        private readonly Dictionary<string, Func<IItem>> dictionary;

        public ItemFactory()
        {
            dictionary = new Dictionary<string, Func<IItem>>
            {
                {
                    "Aged Brie", () => new AgedBrieItem()
                },
                {
                    "Backstage passes to a TAFKAL80ETC concert", () => new BackstageItem()
                },
                {
                    "Sulfuras, Hand of Ragnaros", () => new SulfurasItem()
                },
                {
                    "Conjured", () => new ConjuredItem()
                }
            };
        }
        public IItem CreateItem(string itemName)
        {
            return dictionary.ContainsKey(itemName) ? dictionary[itemName].Invoke() : new NormalItem();
        }
    }
}