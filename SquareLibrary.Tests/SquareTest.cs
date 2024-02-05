namespace SquareLibrary.Tests
{
    [TestFixture]
    public class SquareTest
    {

        [Test]
        public void SquareAreaCalculation()
        {
            Square square = new Square(6);
            Assert.That(square.CalculateArea(), Is.EqualTo(113.04).Within(0.1));
        }

        [Test]
        public void InvalidSquareSide()
        {
            Assert.Throws<ArgumentException>(() => new Square(-5));
        }
    }
}