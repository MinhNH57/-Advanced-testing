using ConsoleApp1;

namespace PhepChia
{
    [TestFixture]
    public class Tests
    {
        //[Test]

        //public void TestChoKhong()
        //{
        //    Assert.Throws<DivideByZeroException>(() => TinhsToan.Divide1(1 , 0));
        //}

        //[Test]

        //public void TestVuotBienTu()
        //{
        //    Assert.Throws<Exception>(() => TinhsToan.Divide1(1001, 19));
        //}
        [Test]
        public void TestChia_SoDuongChoSoDuong()
        {
            Assert.That(5, Is.EqualTo(TinhsToan.Chia(10, 2)));
        }

        [Test]
        public void TestChia_SoAmChoSoDuong()
        {
            Assert.That(-5, Is.EqualTo(TinhsToan.Chia(-10, 2)));
        }

        [Test]
        public void TestChia_SoDuongChoSoAm()
        {
            Assert.That(-5, Is.EqualTo(TinhsToan.Chia(10,-2)));
        }

        [Test]
        public void TestChia_SoAmChoSoAm()
        {
            Assert.That(5, Is.EqualTo(TinhsToan.Chia(-10, -2)));
        }

        [Test]
        public void TestChia_So0ChoSoDuong()
        {
            Assert.That(0, Is.EqualTo(TinhsToan.Chia(0, 5)));
        }

        [Test]
        public void TestChia_So0ChoSoAm()
        {
            Assert.That(0, Is.EqualTo(TinhsToan.Chia(0, -5)));
        }

        [Test]
        public void TestChia_SoDuongNhoHonSoLonHon()
        {
            Assert.That(0, Is.EqualTo(TinhsToan.Chia(3, 10)));
        }

        [Test]
        public void TestChia_SoAmNhoHonSoLonHon()
        {
            Assert.That(0, Is.EqualTo(TinhsToan.Chia(-3, 10)));
        }

        [Test]
        public void TestChia_SoDuongChoSoNhoHon()
        {
            Assert.That(3, Is.EqualTo(TinhsToan.Chia(7, 2)));
        }

        [Test]
        public void TestChia_SoDuongChoSo0()
        {
            Assert.Throws<DivideByZeroException>(() => TinhsToan.Chia(5, 0));
        }
    }
}