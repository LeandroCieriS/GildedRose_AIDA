using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Gilded_rose
{
    internal class ItemFactory
    {
        private Dictionary<string, Func<IItem>> _dictionary;
        
        public ItemFactory()
        {
            _dictionary = new Dictionary<string, Func<IItem>>
            {
                {
                    "Aged Brie", () => new AgedBrieItem()
                },
                {
                    "Backstage passes to a TAFKAL80ETC concert", () => new BackstageItem()
                },
                {
                    "Sulfuras, Hand of Ragnaros", () => new SulfurasItem()
                }
                //},
                //{
                //    "Conjured", () => new ConjuredItem()
                //}
            };
        }

        public IItem CreateItem(string itemName)
        {
            if (_dictionary.ContainsKey(itemName))
                return _dictionary[itemName].Invoke();

            return new NormalItem();
        }
    }

    internal interface IItem
    {
        void UpdateQuality(Item item);
    }

    internal class SulfurasItem : IItem
    {
        public void UpdateQuality(Item item)
        {}
    }

    internal class AgedBrieItem : IItem
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            if (item.SellIn >= 0 && item.Quality < 50)
            {
                item.Quality++;
            }
            else if (item.SellIn < 0)
            {
                item.Quality = Math.Min(item.Quality += 2, 50);
            }
        }
    }

    internal class NormalItem : IItem
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            if (item.SellIn > 0 && item.Quality > 0)
            {
                item.Quality--;
            }
            else if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality -= 2;
            }
        }
    }

    internal class BackstageItem : IItem
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality++;
                }

                if (item.SellIn < 10 && item.Quality < 50)
                {
                    item.Quality++;
                }

                if (item.SellIn < 5 && item.Quality < 50)
                {
                    item.Quality++;
                }
            }
        }
    }
}