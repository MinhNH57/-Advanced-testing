using KiemThuDeMau;

namespace ThiThuTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TinhTongThanhCong()
        {
            int[] arr = { 1, 2, 3, 4 };
            var t = TinhTongArr.TinhTong(arr);
            Assert.That(t, Is.EqualTo(10));
        }

        [Test]
        public void TinhTongThatBai_MangRong()
        {
            int[] arr = {};
            Assert.Throws<ArgumentNullException>(() => TinhTongArr.TinhTong(arr));
        }

        [Test]
        public void TinhTongThatBai_MangCo6PhanTu()
        {
            int[] arr = {1,2,3,4,5,6};
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhTongArr.TinhTong(arr));
        }

        [Test]
        public void TinhTongThanhCong_MangCo4PhanTu()
        {
            int[] arr = { 1, 2, 3, 4};
            var t = TinhTongArr.TinhTong(arr);
            Assert.That(t, Is.EqualTo(10));
        }

        [Test]
        public void TinhTongThatBai_MangCo1PhanTu()
        {
            int[] arr = { 1};
            Assert.Throws<ArgumentOutOfRangeException>(() => TinhTongArr.TinhTong(arr));
        }

        [Test]
        public void TinhTongThanhCong_MangCo2PhanTu()
        {
            int[] arr = { 1, 2};
            var t = TinhTongArr.TinhTong(arr);
            Assert.That(t, Is.EqualTo(3));
        }

        [Test]
        public void TinhTongThanhCong_MangLaDaySoAm()
        {
            int[] arr = { -1,-2 ,-2,-5,-7};
            var t = TinhTongArr.TinhTong(arr);
            Assert.That(t, Is.EqualTo(-17));
        }
    }
}