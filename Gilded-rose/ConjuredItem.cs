using System;

namespace Gilded_rose
{
    internal class ConjuredItem : IItem
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            var qualityLoad = 2;

            if (item.SellIn < 0)
                qualityLoad += 2;
            
            item.Quality = Math.Max(item.Quality - qualityLoad, 0);
        }
    }
}