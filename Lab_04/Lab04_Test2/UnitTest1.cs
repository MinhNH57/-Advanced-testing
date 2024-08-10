using Lab_04;
using NUnit.Framework.Interfaces;

namespace Lab04_Test2
{
    [TestFixture]
    public class Tests
    {
        ItemManage ItemManage = new();

        [Test]
        public void KhongTimThayDoiTuongDeSua()
        {
            int nonExistingItemId = 999;
            string newName = "Updated Name";

            Assert.Throws<KeyNotFoundException>(() => ItemManage.Update(nonExistingItemId, newName));
        }

        [Test]
        public void TenMoiVuotQuaGioiHan50KyTu ()
        {
            int nonExistingItemId = 1;
            string newName = "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm";
            Assert.Throws< ArgumentOutOfRangeException> (() => ItemManage.Update(nonExistingItemId, newName));
        }

        [Test]
        public void TenMoiDuoi2KyTu()
        {
            int nonExistingItemId = 2;
            string newName = "m";
            Assert.Throws<ArgumentOutOfRangeException>(() => ItemManage.Update(nonExistingItemId, newName));
        }

        [Test]
        public void TenMoiTrong()
        {
            // Arrange
            int nonExistingItemId = 1;
            string newName = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ItemManage.Update(nonExistingItemId, newName));
        }

        [Test]
        public void TenMoiCo2KyTu()
        {
            ItemManage itemManage = new ItemManage();
            int itemId = 1;
            string newName = "Mi";

            itemManage.Create(new Item(itemId, "Item 1"));

            itemManage.Update(itemId, newName);

            var updatedItem = itemManage.items.Find(x => x.Id == itemId); // Giả sử có một phương thức để lấy item theo Id
            Assert.That(newName, Is.EqualTo(updatedItem.Name));
        }

        [Test]
        public void TenMoiCo49KyTu()
        {
            ItemManage itemManage = new ItemManage();
            int itemId = 1;
            string newName = "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm";

            itemManage.Create(new Item(itemId, "Item 1"));

            itemManage.Update(itemId, newName);

            var updatedItem = itemManage.items.Find(x => x.Id == itemId); 
            Assert.That(newName, Is.EqualTo(updatedItem.Name));
        }

        [Test]
        public void TenMoiCo50KyTu()
        {
            ItemManage itemManage = new ItemManage();
            int itemId = 1;
            string newName = "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm";

            itemManage.Create(new Item(itemId, "Item 1"));

            itemManage.Update(itemId, newName);

            var updatedItem = itemManage.items.Find(x => x.Id == itemId);
            Assert.That(newName, Is.EqualTo(updatedItem.Name));
        }

        [Test]
        public void TenMoiCo5KyTu()
        {
            ItemManage itemManage = new ItemManage();
            int itemId = 1;
            string newName = "mmmmm";

            itemManage.Create(new Item(itemId, "Item 1"));

            itemManage.Update(itemId, newName);

            var updatedItem = itemManage.items.Find(x => x.Id == itemId);
            Assert.That(newName, Is.EqualTo(updatedItem.Name));
        }

        [Test]
        public void TenMoiCo15KyTu()
        {
            ItemManage itemManage = new ItemManage();
            int itemId = 1;
            string newName = "mmmmmmmmmmmmmmm";

            itemManage.Create(new Item(itemId, "Item 1"));

            itemManage.Update(itemId, newName);

            var updatedItem = itemManage.items.Find(x => x.Id == itemId);
            Assert.That(newName, Is.EqualTo(updatedItem.Name));
        }

        [Test]
        public void TenMoiCo10KyTu()
        {
            ItemManage itemManage = new ItemManage();
            int itemId = 1;
            string newName = "mmmmmmmmmm";

            itemManage.Create(new Item(itemId, "Item 1"));

            itemManage.Update(itemId, newName);

            var updatedItem = itemManage.items.Find(x => x.Id == itemId);
            Assert.That(newName, Is.EqualTo(updatedItem.Name));
        }
    }
}