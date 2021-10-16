using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Gilded_rose
{
    internal static class UpdateTools
    {
        public static void DecreaseSellIn(Item item)
        {
            item.SellIn -= 1;
        }

        public static void DecreaseQuality(Item item, int value = 1)
        {
            for (var i = 0; i < value; i++)
            {
                if (item.Quality > 0)
                {
                    item.Quality -= 1;
                }
            }
        }

        public static bool IsExpired(Item item)
        {
            return item.SellIn < 0;
        }

        public static void IncreaseQuality(Item item, int value = 1)
        {
            for (var i = 0; i < value; i++)
            {
                if (item.Quality < 50)
                {
                    item.Quality += 1;
                }
            }
        }
    }
}