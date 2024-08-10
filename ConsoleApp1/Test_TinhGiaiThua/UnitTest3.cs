using ConsoleApp1;

namespace Test_TinhGiaiThua
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_GiaiThua1()
        {
            int result = TinhsToan.GiaiThua(1);
            int expected = 1;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GiaiThua2()
        {
            int result = TinhsToan.GiaiThua(2);
            int expected = 2;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GiaiThua3()
        {
            int result = TinhsToan.GiaiThua(3);
            int expected = 6;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GiaiThua4()
        {
            int result = TinhsToan.GiaiThua(4);
            int expected = 24;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GiaiThua5()
        {
            int result = TinhsToan.GiaiThua(5);
            int expected = 120;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GiaiThua6()
        {
            int result = TinhsToan.GiaiThua(6);
            int expected = 720;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GiaiThua7()
        {
            int result = TinhsToan.GiaiThua(7);
            int expected = 5040;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GiaiThua8()
        {
            int result = TinhsToan.GiaiThua(8);
            int expected = 40320;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GiaiThua9()
        {
            int result = TinhsToan.GiaiThua(9);
            int expected = 362880;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GiaiThua10()
        {
            int result = TinhsToan.GiaiThua(10);
            int expected = 3628800;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}