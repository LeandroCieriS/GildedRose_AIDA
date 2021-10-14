using System;

namespace Gilded_rose
{
    internal class BackstageItem : IItem
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            if (item.SellIn < 0)
                item.Quality = 0;
            else
            {
                var qualityLoad = 1;

                if (item.SellIn < 10)
                    qualityLoad++;

                if (item.SellIn < 5)
                    qualityLoad++;

                item.Quality = Math.Min(item.Quality += qualityLoad, 50);
            }
        }
    }
}