using ConsoleApp1;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_tinhTong1()
        {
            int result = TinhsToan.TinhTong(1, 1);
            int expected = 2;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTong2()
        {
            int result = TinhsToan.TinhTong(1, 2);
            int expected = 3;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTong3()
        {
            int result = TinhsToan.TinhTong(1, -1);
            int expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTong4()
        {
            int result = TinhsToan.TinhTong(1, 4);
            int expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTong5()
        {
            int result = TinhsToan.TinhTong(1, 5);
            int expected = 6;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTong6()
        {
            int result = TinhsToan.TinhTong(1, 6);
            int expected = 7;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTong7()
        {
            int result = TinhsToan.TinhTong(1, 7);
            int expected = 8;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTong8()
        {
            int result = TinhsToan.TinhTong(1, 8);
            int expected = 9;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTong9()
        {
            int result = TinhsToan.TinhTong(1, 9);
            int expected = 10;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTong10()
        {
            int result = TinhsToan.TinhTong(1, 10);
            int expected = 11;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GiaTriZero()
        {
            Assert.That(0, Is.EqualTo( TinhsToan.TinhTong(0, 0)));
        }

        [Test]
        public void CaHaiSoNguyenHopLe()
        {
            Assert.That(15,Is.EqualTo( TinhsToan.TinhTong(5, 10)));
        }

        [Test]
        public void MotSoAmMotSoDuong()
        {
            Assert.That(4, Is.EqualTo(TinhsToan.TinhTong(-3, 7)));
        }

        [Test]
        public void CaHaiSoDeuAm()
        {
            Assert.That(-10, Is.EqualTo( TinhsToan.TinhTong(-4, -6)));
        }

        [Test]
        public void MotGiaTriKhongPhaiSoNguyen()
        {
            Assert.Throws<ArgumentException>(() => Is.EqualTo( TinhsToan.TinhTong(5, "Minh")));
        }

        [Test]
        public void CaHaiGiaTriKhongPhaiSoNguyen()
        {
            Assert.Throws<ArgumentException>(() => TinhsToan.TinhTong("hi", "hello"));
        }

        [Test]
        public void SoNguyenBienNhoNhat()
        {
            Assert.That(int.MinValue, Is.EqualTo(TinhsToan.TinhTong(int.MinValue, 0)));
        }

        [Test]
        public void SoNguyenBienLonNhat()
        {
            Assert.That(int.MaxValue, Is.EqualTo( TinhsToan.TinhTong(int.MaxValue, 0)));
        }

        [Test]
        public void SoNguyenBienNhoNhatVaSoNguyenDuong()
        {
            Assert.That(int.MinValue + 1, Is.EqualTo( TinhsToan.TinhTong(int.MinValue, 1)));
        }

        [Test]
        public void SoNguyenBienLonNhatVaSoNguyenAm()
        {
            Assert.That(int.MaxValue - 1,Is.EqualTo( TinhsToan.TinhTong(int.MaxValue, -1)));
        }
    }
}