using Lab7_8;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab7_8
{
    [TestFixture]
    internal class TestBaiHat
    {
        BaiHatSer bhs = new BaiHatSer();

        [Test]
        public void DoDaiLaMotSoAm()
        {
            BaiHat item = new BaiHat("BH1", "Em cua ngay hom qua", "Son Tung", "Son Tung", -4);

            Assert.Throws<ArgumentOutOfRangeException>(() => bhs.Create(item));

        }

        [Test]
        public void ThemMoiBaiHatThanhCong()
        {
            BaiHat item = new BaiHat("BH01" ,"Em cua ngay hom qua" , "Son Tung" , "Son Tung" , 4);

            bhs.Create(item);
            CollectionAssert.Contains(bhs.bh, item);
        }

        [Test]
        public void ThemMoiBaiHatNull()
        {
            BaiHat item4 = new("BH02" , "" , "Minh" , "Minh" , 9);
            Assert.Throws<ArgumentNullException>(() => bhs.Create(item4));
        }

        [Test]
        public void TenChuaKhoangTrang()
        {
            BaiHat item5 = new("Mn" , "    " , "Tao" , "tap" , 8);
            Assert.Throws<ArgumentNullException>(() => bhs.Create(item5));
        }

        [Test]
        public void TenChua50KyTu()
        {
            BaiHat item6 = new BaiHat("nh", "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm", "Tao", "tap", 8);

            bhs.Create(item6);
            CollectionAssert.Contains(bhs.bh, item6);
        }

        [Test]
        public void TenChua2KyTu()
        {
            BaiHat item7 = new BaiHat("hdsa", "mm" , "Tao", "tap", 8);

            bhs.Create(item7);
            CollectionAssert.Contains(bhs.bh, item7);
        }



        //////////////////////
        ///

        [Test]
        public void IDTruyenVaoKhoangTrang()
        {
            string itemId = " ";
            Assert.Throws<ArgumentNullException>(() => bhs.Remove(itemId));
        }

        [Test]
        public void IDTruyenVaoCo5KyTu()
        {
            string itemId = "Minh1";
            bhs.Create(new BaiHat(itemId, "Item 1", "Tao", "tap", 8));
            bhs.Remove(itemId);
            Assert.That(!bhs.bh.Any(item => item.ID == itemId));

        }

        [Test]
        public void IDTruyenVaoCo20KyTu()
        {
            string itemId = "mmmmmmmmmmmmmmmmmmmm";
            bhs.Create(new BaiHat(itemId, "Item 1", "Tao", "tap", 8));
            bhs.Remove(itemId);
            Assert.That(!bhs.bh.Any(item => item.ID == itemId));

        }

        [Test]
        public void IDTruyenVaoLonHon20KyTu()
        {

            string itemId = "mmmmmmmmmmmmmmmmmmmmmmmmm";
            Assert.Throws<ArgumentOutOfRangeException>(() => bhs.Remove(itemId));
        }

        [Test]
        public void IdTruyenVaoNhoHon2KyTu()
        {
            string itemId = "m";
            Assert.Throws<ArgumentOutOfRangeException>(() => bhs.Remove(itemId));
        }

    }
}
