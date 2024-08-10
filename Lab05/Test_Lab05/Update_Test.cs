using Lab05;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Lab05
{
    [TestFixture]
    internal class Update_Test
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
        public void UpdateKhongThanhCong_IDKhongHopLe_IDTrungNhau()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "SP03", tenSanPham = "Sản phẩm cập nhật", gia = 1500, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 15 };

            var ex = Assert.Throws<ArgumentException>(() => sanPhamService.UpdateSanPham("1", updatedSanPham));
            Assert.That(ex.Message, Is.EqualTo("ID cập nhật đã tồn tại trong danh sách sản phẩm."));
        }
        [Test]
        public void UpdateKhongThanhCong_IDKhongHopLe_IDKhongCoSP()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "03", tenSanPham = "Sản phẩm cập nhật", gia = 1500, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 15 };

            var ex = Assert.Throws<ArgumentException>(() => sanPhamService.UpdateSanPham("2", updatedSanPham));
        }

        [Test]
        public void UpdateKhongThanhCong_SoLuongNhoHon0()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "03", tenSanPham = "Sản phẩm cập nhật", gia = 1500, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = -1 };
            var ex = Assert.Throws<ArgumentException>(() => sanPhamService.UpdateSanPham("1", updatedSanPham));
        }

        [Test]
        public void UpdateKhongThanhCong_SoLuongNhoLonHon100()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "03", tenSanPham = "Sản phẩm cập nhật", gia = 1500, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 101 };
            var ex = Assert.Throws<ArgumentException>(() => sanPhamService.UpdateSanPham("2", updatedSanPham));
        }

        [Test]
        public void UpdateThanhCong_SoLuong99()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "SP03", tenSanPham = "Sản phẩm cập nhật", gia = 1500, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 99 };
            sanPhamService.UpdateSanPham("2", updatedSanPham);

            var updatedProduct = sanPhamService.GetAllSanPhams().First(sp => sp.id == "2");
            Assert.That(updatedProduct.soLuong , Is.EqualTo(99));
        }

        [Test]
        public void UpdateThanhCong_SoLuong0()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "SP03", tenSanPham = "Sản phẩm cập nhật", gia = 1500, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 0 };
            sanPhamService.UpdateSanPham("2", updatedSanPham);

            var updatedProduct = sanPhamService.GetAllSanPhams().First(sp => sp.id == "2");
            Assert.That(updatedProduct.soLuong, Is.EqualTo(0));
        }

        [Test]
        public void UpdateThanhCong_SoLuong50()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "SP03", tenSanPham = "Sản phẩm cập nhật", gia = 1500, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 50 };
            sanPhamService.UpdateSanPham("2", updatedSanPham);

            var updatedProduct = sanPhamService.GetAllSanPhams().First(sp => sp.id == "2");
            Assert.That(updatedProduct.soLuong, Is.EqualTo(50));
        }

        [Test]
        public void UpdateSanPham_GiaTienBang0()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "03", tenSanPham = "Sản phẩm cập nhật", gia = 0, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 101 };
            var ex = Assert.Throws<ArgumentException>(() => sanPhamService.UpdateSanPham("2", updatedSanPham));
        }

        [Test]
        public void UpdateSanPham_GiaTienNhoHon1000()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "03", tenSanPham = "Sản phẩm cập nhật", gia = 700, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 101 };
            var ex = Assert.Throws<ArgumentException>(() => sanPhamService.UpdateSanPham("2", updatedSanPham));
        }

        [Test]
        public void UpdateSanPham_GiaTienLonHon1000000000()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "03", tenSanPham = "Sản phẩm cập nhật", gia = 10000000001, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 101 };
            var ex = Assert.Throws<ArgumentException>(() => sanPhamService.UpdateSanPham("2", updatedSanPham));
        }

        [Test]
        public void UpdateSanPham_GiaTienBang999()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "03", tenSanPham = "Sản phẩm cập nhật", gia = 999, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 101 };
            var ex = Assert.Throws<ArgumentException>(() => sanPhamService.UpdateSanPham("2", updatedSanPham));
        }

        [Test]
        public void UpdateSanPham_GiaTienBang1001()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "SP03", tenSanPham = "Sản phẩm cập nhật", gia = 1001, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 50 };
            sanPhamService.UpdateSanPham("2", updatedSanPham);

            var updatedProduct = sanPhamService.GetAllSanPhams().First(sp => sp.id == "2");
            Assert.That(updatedProduct.soLuong, Is.EqualTo(50));
        }

        [Test]
        public void UpdateSanPham_TenSPNull ()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "03", tenSanPham = "", gia = 0, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 101 };
            var ex = Assert.Throws<ArgumentNullException>(() => sanPhamService.UpdateSanPham("2", updatedSanPham));
        }

        [Test]
        public void UpdateSanPham_MaSPNull()
        {
            var updatedSanPham = new SanPham { id = "2", maSanPham = "", tenSanPham = "San Pham 01", gia = 0, mauSac = "Vàng", kichThuoc = "Nhỏ", soLuong = 101 };
            var ex = Assert.Throws<ArgumentNullException>(() => sanPhamService.UpdateSanPham("2", updatedSanPham));
        }
    }
}
