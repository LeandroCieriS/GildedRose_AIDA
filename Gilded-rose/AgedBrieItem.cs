using static Gilded_rose.UpdateTools;

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
        }
    }
}