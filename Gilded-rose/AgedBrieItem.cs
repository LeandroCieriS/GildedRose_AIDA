<<<<<<< HEAD
﻿using static Gilded_rose.UpdateTools;

namespace Gilded_rose
{
    public class AgedBrieItem : IItem
    {
        public void UpdateStatus(Item item)
        {
            IncreaseQuality(item);
            DecreaseSellIn(item);
            if (IsExpired(item))
            {
                IncreaseQuality(item);
            }
=======
﻿using System;

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
>>>>>>> main
        }
    }
}