using Lab08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Lab08
{
    [TestFixture]
    internal class TestString
    {
        [Test]
        public void NoiChuoiThanhCong()
        {
            string m = Concatenate.ConcatenateString("Nguyen", "Minh");
            Assert.That(m, Is.EqualTo("NguyenMinh"));
        }

        [Test]
        public void NoiChuoiThatBai_CaHaiCHuoiDeuNull()
        {
            Assert.Throws<NullReferenceException>(() => Concatenate.ConcatenateString(null, null));
        }

        [Test]
        public void NoiChuoiThatBai_CoMotChuoiNull1()
        {
            Assert.Throws<NullReferenceException>(() => Concatenate.ConcatenateString("Minh", null));
        }

        [Test]
        public void NoiChuoiThatBai_CoMotChuoiNull2()
        {
            Assert.Throws<NullReferenceException>(() => Concatenate.ConcatenateString(null, "Nguyen"));
        }
    }
}
