using Lab_04;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Legacy;

namespace Lab04_Test1
{
    [TestFixture]
    public class Tests
    {
        ItemManage itemManage = new();
        [Test]
        public void TenVuotQua50KyTu()
        {
            Item item1 = new(1, "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm");
            Assert.Throws<ArgumentOutOfRangeException>(() => itemManage.Create(item1));
        }

        [Test]
        public void TenDuoi2KyTu()
        {
            Item item2 = new(2, "m");
            Assert.Throws<ArgumentOutOfRangeException>(() => itemManage.Create(item2));
        }

        [Test]
        public void TenCoDoDai10KyTu()
        {
            Item item3 = new Item(3, "TenKyTu10");

            itemManage.Create(item3);
            CollectionAssert.Contains(itemManage.items, item3);
        }

        [Test]
        public void TenNull()
        {
            Item item4 = new(4, null);
            Assert.Throws<ArgumentNullException>(() => itemManage.Create(item4));
        }

        [Test]
        public void TenChuaKhoangTrang()
        {
            Item item5 = new(5, "     ");
            Assert.Throws<ArgumentNullException>(() => itemManage.Create(item5));
        }

        [Test]
        public void TenChua50KyTu()
        {
            Item item6 = new Item(6, "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm");

            itemManage.Create(item6);
            CollectionAssert.Contains(itemManage.items, item6);
        }

        [Test]
        public void TenChua2KyTu()
        {
            Item item7 = new Item(7, "mm");

            itemManage.Create(item7);
            CollectionAssert.Contains(itemManage.items, item7);
        }

        [Test]
        public void TenKhongPhaiLaChu()
        {
            Item item8 = new Item(8, "901");
            Assert.Throws<ArgumentException>(() => itemManage.Create(item8));
        }

        [Test]
        public void IDLaMotSoAm()
        {
            Item item9 = new Item(-9, "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm");

            itemManage.Create(item9);
            CollectionAssert.Contains(itemManage.items, item9);
        }

        [Test]
        public void IDLaMotSoDuong()
        {
            Item item10 = new Item(10, "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm");

            itemManage.Create(item10);
            CollectionAssert.Contains(itemManage.items, item10);
        }
    }
}