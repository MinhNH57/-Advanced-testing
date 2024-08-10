using Lab7_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab7_8
{
    [TestFixture]
    public class TestNhan
    {
        [Test]
        public void HaiSoLonHon100()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhToan.Nhan(101, 109));
        }

        [Test]
        public void HaiSoNhoHon0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhToan.Nhan(-1, -109));
        }

        [Test]
        public void HaiSoDeuLaSoNguyenDuong()
        {
            Assert.That(10 , Is.EqualTo(TinhToan.Nhan(10 , 1)));
        }
    }
}
