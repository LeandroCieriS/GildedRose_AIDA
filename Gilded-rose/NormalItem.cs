<<<<<<< HEAD
﻿using static Gilded_rose.UpdateTools;

namespace Gilded_rose
{
    public class NormalItem : IItem
    {
        public void UpdateStatus(Item item)
        {
            DecreaseQuality(item);
            DecreaseSellIn(item);
            if (IsExpired(item))
            {
                DecreaseQuality(item);
            }
=======
﻿using System;

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
>>>>>>> main
        }
    }
}