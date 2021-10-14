using System;

namespace Gilded_rose
{
    internal class AgedBrieItem : IItem
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            if (item.SellIn >= 0 && item.Quality < 50)
                item.Quality++;
            else if (item.SellIn < 0)
                item.Quality = Math.Min(item.Quality + 2, 50);
        }
    }
}