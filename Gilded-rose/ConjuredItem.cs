using static Gilded_rose.UpdateTools;

namespace Gilded_rose
{
    internal class ConjuredItem : IItem
    {
        public void UpdateStatus(Item item)
        {
            DecreaseQuality(item, 2);
            DecreaseSellIn(item);
            if (IsExpired(item))
            {
                DecreaseQuality(item, 2);
            }
        }
    }
}