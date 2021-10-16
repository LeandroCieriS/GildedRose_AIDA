<<<<<<< HEAD
﻿using static Gilded_rose.UpdateTools;

namespace Gilded_rose
{
    public class BackstageItem : IItem
    {
        public void UpdateStatus(Item item)
        {
            var qualityUpdateValue = 1;
            if (IsSecondRangePrice(item))
            {
                qualityUpdateValue++;
            }
            if (IsThirdRangePrice(item))
            {
                qualityUpdateValue++;
            }
            IncreaseQuality(item, qualityUpdateValue);
            DecreaseSellIn(item);
            if (IsExpired(item))
            {
                item.Quality = 0;
            }
        }

        private static bool IsThirdRangePrice(Item item)
        {
            return item.SellIn < 6;
        }

        private static bool IsSecondRangePrice(Item item)
        {
            return item.SellIn < 11;
=======
﻿using System;

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
>>>>>>> main
        }
    }
}