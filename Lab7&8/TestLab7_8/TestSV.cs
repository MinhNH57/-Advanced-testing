using Lab7_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab7_8
{
    [TestFixture]
    internal class TestSV
    {
        [Test]
        public void SinhVienCoDiemTrongKhoangF()
        {
            Assert.That("F" , Is.EqualTo( XepHangSV.XepHangSinhVien(37)));
        }

        [Test]
        public void SinhVienCoDiemTrongKhoangD()
        {
            Assert.That("D", Is.EqualTo(XepHangSV.XepHangSinhVien(42)));
        }

        [Test]
        public void SinhVienCoDiemTrongKhoangC()
        {
            Assert.That("C", Is.EqualTo(XepHangSV.XepHangSinhVien(65)));
        }

        [Test]
        public void SinhVienCoDiemTrongKhoangB()
        {
            Assert.That("B", Is.EqualTo(XepHangSV.XepHangSinhVien(76)));
        }

        [Test]
        public void SinhVienCoDiemTrongKhoangA()
        {
            Assert.That("A", Is.EqualTo(XepHangSV.XepHangSinhVien(82)));
        }

        [Test]
        public void SinhVienCoDiemTuyetDoi()
        {
            Assert.That("A", Is.EqualTo(XepHangSV.XepHangSinhVien(100)));
        }

        [Test]
        public void SinhVienCoDiemKhoHopLe_DiemLonHon100()
        {
            Assert.Throws<ArgumentException>(() => XepHangSV.XepHangSinhVien(109));
        }

        [Test]
        public void SinhVienCoDiemKhongHopLe_DiemNhoHonKhong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => XepHangSV.XepHangSinhVien(-9));
        }
    }
}
