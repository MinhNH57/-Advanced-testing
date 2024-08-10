using Lab08;

namespace Test_Lab08
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TinhTrungBinhThanhCong()
        {
            var kq =  TinhDiemtrungBinh.TinhDiemTrungBinh(6, 7, 8, 3);
            Assert.That(kq, Is.EqualTo(7));
        }

        [Test]
        public void TinhTrungBinhThatBai_ABang0()
        {
            Assert.Throws<ArgumentException>(() => TinhDiemtrungBinh.TinhDiemTrungBinh(6, 7, 8, 0));
        }

        [Test]
        public void TinhDiemTrungBinhThatBai_Alasoam()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhDiemtrungBinh.TinhDiemTrungBinh(6, 7, 8, -3));
        }

        [Test]
        public void TinhTrungBinhThatBai_Alonhon3()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhDiemtrungBinh.TinhDiemTrungBinh(6, 7, 8, 4));
        }

        [Test]
        public void TinhTrungBinhThatBai_CacDiemLonHon10()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhDiemtrungBinh.TinhDiemTrungBinh(16, 17, 18, 3));
        }

        [Test]
        public void TinhTrungBinhThatBai_CacDiemNhoHon0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhDiemtrungBinh.TinhDiemTrungBinh(-1, -17, -18, 3));
        }

        [Test]
        public void TinhTrungBinhThatBai_DiemLynhoHon0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhDiemtrungBinh.TinhDiemTrungBinh(10, -17, 8, 3));
        }

        [Test]
        public void TinhTrungBinhThatBai_DiemToannhoHon0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhDiemtrungBinh.TinhDiemTrungBinh(-10, 9, 8, 3));
        }

        [Test]
        public void TinhTrungBinhThatBai_DiemHoanhoHon0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhDiemtrungBinh.TinhDiemTrungBinh(10, 9, -8, 3));
        }

        [Test]
        public void TinhTrungBinhThatBai_DiemHoaLonHon10()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhDiemtrungBinh.TinhDiemTrungBinh(10, 9, 11, 3));
        }
    }
}