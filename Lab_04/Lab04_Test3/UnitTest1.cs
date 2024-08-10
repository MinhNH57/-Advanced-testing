using Lab_04;
using NUnit.Framework;

namespace Lab04_Test3
{
    [TestFixture]
    public class Tests
    {
        ItemManage itemManage = new();
        [Test]
        public void IDTruyenVaoLaSoDuong()
        {
            int itemId = 10;
            itemManage.Create(new Item(itemId, "Item 1"));
            itemManage.Remove(itemId);
            Assert.That(!itemManage.items.Any(item => item.Id == itemId));

        }

        [Test]
        public void IDTruyenVaoLaSoAm()
        {
            int itemId = -10;
            itemManage.Create(new Item(itemId, "Item 1"));
            itemManage.Remove(itemId);
            Assert.That(!itemManage.items.Any(item => item.Id == itemId));

        }

        [Test]
        public void IDTruyenVaoLaSo0()
        {
            int itemId = 0;
            itemManage.Create(new Item(itemId, "Item 1"));
            itemManage.Remove(itemId);
            Assert.That(!itemManage.items.Any(item => item.Id == itemId));

        }

        [Test]
        public void IDTruyenVaoLaSoTrongKhoangAm()
        {
            int itemId = -6;
            itemManage.Create(new Item(itemId, "Item 1"));
            itemManage.Remove(itemId);
            Assert.That(!itemManage.items.Any(item => item.Id == itemId));

        }

        [Test]
        public void IDTruyenVaoLaSoTrongKhoangDuong()
        {
            int itemId = 6;
            itemManage.Create(new Item(itemId, "Item 1"));
            itemManage.Remove(itemId);
            Assert.That(!itemManage.items.Any(item => item.Id == itemId));

        }
    }
}