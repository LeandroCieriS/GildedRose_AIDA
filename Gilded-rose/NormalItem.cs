using System;

namespace Gilded_rose
{
    internal class NormalItem : IItem
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            var qualityLoad = 1;

            if (item.SellIn < 0)
                qualityLoad ++;

            item.Quality = Math.Max(item.Quality - qualityLoad, 0);
        }
    }
}