using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Gilded_rose.Test
{
    public class GildedRoseShould
    {
        [TestCase(10, 20, 19)]
        [TestCase(-4, 25, 23)]
        [TestCase(10, 0, 0)]
        public void decrease_quality_of_items(int sellIn, int quality, int expectedQuality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Normal item", SellIn = sellIn, Quality = quality } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(sellIn-1);
            Items.First().Quality.Should().Be(expectedQuality);
        }


        [TestCase(1, 20, 21)]
        [TestCase(0, 20, 22)]
        public void increase_quality_of_aged_brie(int sellIn, int quality, int expectedQuality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = sellIn, Quality = quality } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(sellIn-1);
            Items.First().Quality.Should().Be(expectedQuality);
        }

        [Test]
        public void should_not_increase_quality_of_item_above_fifty()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 49} };
            var app = new GildedRose(Items);

            app.UpdateQuality();
            
            Items.First().SellIn.Should().Be(-1);
            Items.First().Quality.Should().Be(50);
        }
        
        [Test]
        public void not_decrease_quality_of_legendary_item()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 2, Quality = 80 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(2);
            Items.First().Quality.Should().Be(80);
        }

        [TestCase(11, 30, 31)]
        [TestCase(10, 30, 32)]
        [TestCase(5, 30, 33)]
        [TestCase(0, 30, 0)]
        public void should_increase_quality_of_backstage(int sellIn, int quality,  int expectedQuality)
        {
            IList<Item> Items = new List<Item> { new Item 
                { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(sellIn-1);
            Items.First().Quality.Should().Be(expectedQuality);
        }
    }
}