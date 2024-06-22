using NUnit.Framework;
using System;
using GeometryLibrary.Figures;
using GeometryLibrary.Extensions;

namespace GeometryLibrary.Tests
{
    public class TriangleTests
    {
        [Test]
        public void Triangle_WithValidSides_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, (double)triangle.GetArea(), 1e-10);
        }

        [Test]
        public void Triangle_WithInvalidSides_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 10));
        }

        [Test]
        public void Triangle_IsRightAngled_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [Test]
        public void Triangle_IsRightAngled_ReturnsFalse()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightAngled());
        }
    }
}
