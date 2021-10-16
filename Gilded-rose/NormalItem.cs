using static Gilded_rose.UpdateTools;

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
        }
    }
}