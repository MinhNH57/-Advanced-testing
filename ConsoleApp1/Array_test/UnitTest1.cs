using ConsoleApp1;

namespace Array_test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GetElementAtIndex_ChỉMụcTrongPhạmVi_TrảVềPhầnTử()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int result = TinhsToan.GetElementAtIndex(array, 2);
            Assert.That(3,Is.EqualTo( result));
        }

        [Test]
        public void GetElementAtIndex_ChỉMụcNgoàiPhạmVi_NémNgoạiLệIndexOutOfRangeException()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Assert.Throws<IndexOutOfRangeException>(() => TinhsToan.GetElementAtIndex(array, -1));
            Assert.Throws<IndexOutOfRangeException>(() => TinhsToan.GetElementAtIndex(array, 5));
        }
    }
}