using Lab08;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Lab08
{
    [TestFixture]
    internal class TestSach
    {
            SachService ss = new SachService();

        [Test]
        public void ThemThanhCong()
        {
            var newSach = new Sach()
            {
                Id = "BO09" , Name = "Di de tro ve" , Sotrang = 123 , LanTaiBan = 1  , TenTacGia = "Nguyen Dinh Minh"
            };

            ss.CreateSach(newSach);

            CollectionAssert.Contains(ss.GetAll(), newSach);
        }

        [Test]
        public void ThemThatBai_IDKhongHopLe_IDtren10kytu()
        {
            var newSach = new Sach()
            {
                Id = "BO0900000000",
                Name = "Di de tro ve",
                Sotrang = 123,
                LanTaiBan = 1,
                TenTacGia = "Nguyen Dinh Minh"
            };

            Assert.Throws<ArgumentOutOfRangeException>(() => ss.CreateSach(newSach));
        }

        [Test]
        public void ThemThatBai_IDKhongHopLe_IDDuoi1KyTu()
        {
            var newSach = new Sach()
            {
                Id = "",
                Name = "Di de tro ve",
                Sotrang = 123,
                LanTaiBan = 1,
                TenTacGia = "Nguyen Dinh Minh"
            };

            Assert.Throws<ArgumentOutOfRangeException>(() => ss.CreateSach(newSach));
        }

        [Test]
        public void ThemThanhcong_ID10KyTu()
        {
            var newSach = new Sach()
            {
                Id = "A11111111",
                Name = "Di de tro ve",
                Sotrang = 123,
                LanTaiBan = 1,
                TenTacGia = "Nguyen Dinh Minh"
            };
            ss.CreateSach(newSach);
            CollectionAssert.Contains(ss.GetAll(), newSach);
        }

        [Test]
        public void ThemThanhcong_ID1KyTu()
        {
            var newSach = new Sach()
            {
                Id = "A",
                Name = "Di de tro ve",
                Sotrang = 123,
                LanTaiBan = 1,
                TenTacGia = "Nguyen Dinh Minh"
            };
            ss.CreateSach(newSach);
            CollectionAssert.Contains(ss.GetAll(), newSach);
        }

        [Test]
        public void ThemThaBai_TenSachChuaKyTuDacBiet()
        {
            var newSach = new Sach()
            {
                Id = "A",
                Name = "Di de tro v!@",
                Sotrang = 123,
                LanTaiBan = 1,
                TenTacGia = "Nguyen Dinh Minh"
            };

            Assert.Throws<ArgumentException>(() => ss.CreateSach(newSach));
        }

        [Test]
        public void TimKiemThanhCong_TenTacgiaHopLe()
        {

        }
    }
}
