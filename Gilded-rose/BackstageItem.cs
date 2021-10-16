using static Gilded_rose.UpdateTools;

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
        }
    }
}