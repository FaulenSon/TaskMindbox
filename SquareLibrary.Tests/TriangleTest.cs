namespace SquareLibrary.Tests
{
    [TestFixture]
    public class TriangleTest
    {

        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(7, 9, 6);
            Assert.That(triangle.CalculateArea(), Is.EqualTo(20.97).Within(0.01));
        }

        [Test]
        public void InvalidTriangleSides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
        }

        [Test]
        public void TriangleIsRightAngle()
        {
            var triangle = new Triangle(3, 4, 5);
            bool result = triangle.IsRightAngleTriangle();
            Assert.IsTrue(result);
        }

        [Test]
        public void TriangleIsNotRightAngle()
        {
            var triangle = new Triangle(2, 3, 4);
            bool result = triangle.IsRightAngleTriangle();
            Assert.IsFalse(result);
        }
    }
}