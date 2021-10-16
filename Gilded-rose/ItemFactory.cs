using System;
using System.Collections.Generic;

namespace Gilded_rose
{
    internal class ItemFactory
    {
<<<<<<< HEAD
        private readonly Dictionary<string, Func<IItem>> dictionary;

        public ItemFactory()
        {
            dictionary = new Dictionary<string, Func<IItem>>
=======
        private readonly Dictionary<string, Func<IItem>> _dictionary;
        
        public ItemFactory()
        {
            _dictionary = new Dictionary<string, Func<IItem>>
>>>>>>> main
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
<<<<<<< HEAD
            };
        }
        public IItem CreateItem(string itemName)
        {
            return dictionary.ContainsKey(itemName) ? dictionary[itemName].Invoke() : new NormalItem();
=======
        };
        }

        public IItem CreateItem(string itemName)
        {
            if (_dictionary.ContainsKey(itemName))
                return _dictionary[itemName].Invoke();

            return new NormalItem();
>>>>>>> main
        }
    }
}