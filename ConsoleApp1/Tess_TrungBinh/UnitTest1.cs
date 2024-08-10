using ConsoleApp1;

namespace Tess_TrungBinh
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TinhTrungBinh_DanhSachRong_ThrowsArithmeticException()
        {
            // Sắp xếp (Arrange)
            var danhSachRong = new List<double>();

            // Hành động và Xác nhận (Act & Assert)
            Assert.Throws<ArithmeticException>(() => TinhsToan.TinhTrungBinh(danhSachRong));
        }

        [Test]
        public void TinhTrungBinh_DanhSachNull_ThrowsArithmeticException()
        {
            // Sắp xếp (Arrange)
            List<double> danhSachNull = null;

            // Hành động và Xác nhận (Act & Assert)
            Assert.Throws<ArithmeticException>(() => TinhsToan.TinhTrungBinh(danhSachNull));
        }
        [Test]
        public void TinhTrungBinh_DanhSachKhongRong_TraVeGiaTriDung()
        {
            // Sắp xếp (Arrange)
            var numbers = new List<double> { 1, 2, 3, 4, 5 };

            // Hành động (Act)
            var result = TinhsToan.TinhTrungBinh(numbers);

            // Xác nhận (Assert)
            Assert.That(3,Is.EqualTo (result));
        }
    }
}