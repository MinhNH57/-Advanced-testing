using Lab7_8;

namespace TestLab7_8
{
    public class Tests
    {
        [Test]
        public void ChiaChoSo0()
        {
            Assert.Throws<DivideByZeroException>(() => TinhToan.Chia(1, 0));
        }

        [Test]
        public void TestChia_SoDuongChoSoDuong()
        {
            Assert.That(5, Is.EqualTo(TinhToan.Chia(10, 2)));
        }

        [Test]
        public void TestChia_SoAmChoSoDuong()
        {
            Assert.That(-5, Is.EqualTo(TinhToan.Chia(-10, 2)));
        }

        [Test]
        public void TestChia_SoDuongChoSoAm()
        {
            Assert.That(-5, Is.EqualTo(TinhToan.Chia(10, -2)));
        }

        [Test]
        public void TestChia_SoAmChoSoAm()
        {
            Assert.That(5, Is.EqualTo(TinhToan.Chia(-10, -2)));
        }

        [Test]
        public void TestChia_So0ChoSoDuong()
        {
            Assert.That(0, Is.EqualTo(TinhToan.Chia(0, 5)));
        }

        [Test]
        public void TestChia_So0ChoSoAm()
        {
            Assert.That(0, Is.EqualTo(TinhToan.Chia(0, -5)));
        }
    }
}