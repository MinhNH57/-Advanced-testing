using ConsoleApp1;

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_tinhTich1()
        {
            int result = TinhsToan.TinhTich(1, 1);
            int expected = 1;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTich2()
        {
            int result = TinhsToan.TinhTich(1, 2);
            int expected = 2;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTich3()
        {
            int result = TinhsToan.TinhTich(1, 3);
            int expected = 3;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTich4()
        {
            int result = TinhsToan.TinhTich(1, 4);
            int expected = 4;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTich5()
        {
            int result = TinhsToan.TinhTich(1, 5);
            int expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTich6()
        {
            int result = TinhsToan.TinhTich(1, 6);
            int expected = 6;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTich7()
        {
            int result = TinhsToan.TinhTich(1, 7);
            int expected = 7;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTich8()
        {
            int result = TinhsToan.TinhTich(1, 8);
            int expected = 8;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTich9()
        {
            int result = TinhsToan.TinhTich(1, 9);
            int expected = 9;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_tinhTich10()
        {
            int result = TinhsToan.TinhTich(1, 10);
            int expected = 10;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}