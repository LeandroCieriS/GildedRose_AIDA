<<<<<<< HEAD
﻿using static Gilded_rose.UpdateTools;
=======
﻿using System;
>>>>>>> main

namespace Gilded_rose
{
    internal class ConjuredItem : IItem
    {
<<<<<<< HEAD
        public void UpdateStatus(Item item)
        {
            DecreaseQuality(item, 2);
            DecreaseSellIn(item);
            if (IsExpired(item))
            {
                DecreaseQuality(item, 2);
            }
=======
        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            var qualityLoad = 2;

            if (item.SellIn < 0)
                qualityLoad += 2;
            
            item.Quality = Math.Max(item.Quality - qualityLoad, 0);
>>>>>>> main
        }
    }
}