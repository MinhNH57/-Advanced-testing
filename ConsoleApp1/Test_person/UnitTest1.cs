using System;
using ConsoleApp1;

namespace Test_person
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Constructor_InvalidAge_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            string name = "Alice";
            int invalidAge = -5;

            ConsoleApp1.
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Person(name, invalidAge));
        }
    }
}