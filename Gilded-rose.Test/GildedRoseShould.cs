using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Gilded_rose.Test
{
    public class GildedRoseShould
    {

        [Test]
        public void decrease_quality_of_items()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Normal item", SellIn = 10, Quality = 20 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(19);
        }

        [Test]
        public void decrease_quality_of_item_faster_when_expired()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Normal item", SellIn = 0, Quality = 25 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(23);
        }

        [Test]
        public void not_decrease_quality_of_item_when_it_is_zero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Normal item", SellIn = 10, Quality = 0 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(0);
        }

        [Test]
        public void increase_quality_of_aged_brie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 20 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(21);
        }  
        
        [Test]
        public void increase_quality_of_aged_brie_faster_when_expired()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 20 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(22);
        }
        
        [Test]
        public void should_not_increase_quality_of_item_above_fifty()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 49} };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(50);
        }
        
        [Test]
        public void not_decrease_quality_of_legendary_item()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 2, Quality = 80 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(80);
        }

        [Test]
        public void should_increase_quality_of_backstage()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 60, Quality = 30 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(31);
        }

        [Test]
        public void should_increase_quality_of_backstage_twice_as_fast_when_SellIn_between_ten_and_five()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 30 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(32);
        }

        [Test]
        public void should_increase_quality_of_backstage_thrice_as_fast_when_SellIn_between_five_and_zero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 30 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(33);
        }

        [Test]
        public void should_drop_quality_to_zero_when_backstage_item_expires()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 30 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(0);
        }

    }
}