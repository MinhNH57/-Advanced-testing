using Lab05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Lab05
{
    [TestFixture]
    internal class Delete_Test
    {
        private SanPhamService sanPhamService;
        [SetUp]
        public void SetUp()
        {
            sanPhamService = new SanPhamService();
            sanPhamService.AddSanPham(new SanPham { id = "1", maSanPham = "SP01", tenSanPham = "Sản phẩm 1", gia = 1000, mauSac = "Đỏ", kichThuoc = "Lớn", soLuong = 10 });
            sanPhamService.AddSanPham(new SanPham { id = "2", maSanPham = "SP02", tenSanPham = "Sản phẩm 2", gia = 2000, mauSac = "Xanh", kichThuoc = "Vừa", soLuong = 20 });
        }

        [Test]
        public void XoaThanhCong()
        {
            var sanpham_delete = sanPhamService.DeleteSanPham("SP01");
            var s = sanPhamService.GetSanPhamById("1");
            Assert.That(!sanPhamService.GetAllSanPhams().Any(sp => sp.id == "1"));
        }

        [Test] 
        public void XoaKhongThanhCong()
        {
            Assert.Throws<Exception>(() => sanPhamService.DeleteSanPham("SP06"));
        }
    }
}
