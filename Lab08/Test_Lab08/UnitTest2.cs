using Lab08;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Lab08
{
    [TestFixture]
    public class UnitTest2
    {
        [Test]
        public void TinhTongThanhCong()
        {
            var kq = TinhTong.TinhTongN(10);
            Assert.That(kq, Is.EqualTo(55));
        }

        [Test]
        public void TinhTongThatBai_SonhapvaonhoHon0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhTong.TinhTongN(-1));
        }

        [Test]
        public void TinhTongThatBai_Sonhapvaolaam10()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhTong.TinhTongN(-10));
        }

        [Test]
        public void TinhTongThatBai_SonhapvaoLonHon1000()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhTong.TinhTongN(1001));
        }

        [Test]
        public void TinhTongThatBai_SonhapvaoLonHonla1010()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhTong.TinhTongN(1010));
        }

        [Test]
        public void TinhTongThatBai_Sonhapvaola0()
        {
            var kq = TinhTong.TinhTongN(0);
            Assert.That(kq , Is.EqualTo(0));
        }

        [Test]
        public void TinhTongThatBai_Sonhapvaola1000()
        {
            var kq = TinhTong.TinhTongN(1000);
            Assert.That(kq, Is.EqualTo(500500));
        }

        [Test]
        public void TinhTongThatBai_Sonhapvaola1()
        {
            var kq = TinhTong.TinhTongN(1);
            Assert.That(kq, Is.EqualTo(1));
        }

        [Test]
        public void TinhTongThatBai_Sonhapvaola5()
        {
            var kq = TinhTong.TinhTongN(5);
            Assert.That(kq, Is.EqualTo(15));
        }

        [Test]
        public void TinhTongThatBai_Sonhapvaola15()
        {
            var kq = TinhTong.TinhTongN(15);
            Assert.That(kq, Is.EqualTo(120));
        }
    }
}
