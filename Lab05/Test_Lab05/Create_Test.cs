using Lab05;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Legacy;

namespace Test_Lab05
{
    [TestFixture]
    public class Tests
    {
        private SanPhamService sanPhamService;

        [SetUp]
        public void Setup()
        {
            sanPhamService = new SanPhamService();
        }

        [Test]
        public void AddSanPham_SoLuongHopLe()
        {
            var sanPham = new SanPham("1", "SP001", "Sản phẩm 1", 1000, "Đỏ", "L", 10);
            sanPhamService.AddSanPham(sanPham);
            CollectionAssert.Contains(sanPhamService.GetAllSanPhams() , sanPham);
        }

        [Test]
        public void AddSanPham_SoLuongKhongHopLe_SoLuongNhoHon0()
        {
            var sanPham = new SanPham("1", "SP001", "Sản phẩm 1", 1000, "Đỏ", "L", -99);
            Assert.Throws<ArgumentOutOfRangeException> (() => sanPhamService.AddSanPham (sanPham));
        }

        [Test]
        public void AddSanPham_SoLuongKhongHopLe_SoLuongLonHon100()
        {
            var sanPham = new SanPham("1", "SP001", "Sản phẩm 1", 1000, "Đỏ", "L", 101);
            Assert.Throws<ArgumentOutOfRangeException>(() => sanPhamService.AddSanPham(sanPham));
        }
        [Test]
        public void AddSanPham_GiaTienBang0()
        {
            var sanPham = new SanPham("1", "SP001", "Sản phẩm 1", 0, "Đỏ", "L",12);
            Assert.Throws<ArgumentException>(() => sanPhamService.AddSanPham(sanPham));
        }

        [Test]
        public void AddSanPham_GiaTienNhoHon1000()
        {
            var sanPham = new SanPham("1", "SP001", "Sản phẩm 1", 900, "Đỏ", "L", 12);
            Assert.Throws<ArgumentOutOfRangeException>(() => sanPhamService.AddSanPham(sanPham));
        }

        [Test]
        public void AddSanPham_GiaTienLonHon1000000000()
        {
            var sanPham = new SanPham("1", "SP001", "Sản phẩm 1", 10000000011, "Đỏ", "L", 12);
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => sanPhamService.AddSanPham(sanPham));
            Assert.That(ex.Message, Does.Contain("Giá tiền phải nhỏ hơn 1 tỷ."));
        }

        [Test]
        public void AddSanPham_GiaTienNhoBang999()
        {
            var sanPham = new SanPham("1", "SP001", "Sản phẩm 1", 999, "Đỏ", "L", 12);
            Assert.Throws<ArgumentOutOfRangeException>(() => sanPhamService.AddSanPham(sanPham));
        }

        [Test]
        public void AddSanPham_GiaTienBang1001()
        {
            var sanPham = new SanPham("1", "SP001", "Sản phẩm 1", 1001, "Đỏ", "L", 10);
            sanPhamService.AddSanPham(sanPham);
            CollectionAssert.Contains(sanPhamService.GetAllSanPhams(), sanPham);
        }

        [Test]
        public void AddSanPham_TenSanPhamNull()
        {
            var sanPham = new SanPham("1", "SP001", "", 999, "Đỏ", "L", 12);
            Assert.Throws<ArgumentNullException>(() => sanPhamService.AddSanPham(sanPham));
        }

    }
}