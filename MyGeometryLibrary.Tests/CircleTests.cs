using NUnit.Framework;
using System;
using GeometryLibrary.Figures;
using GeometryLibrary.Extensions;
namespace GeometryLibrary.Tests
{
    public class CircleTests
    {
        [Test]
        public void Circle_WithValidRadius_ReturnsCorrectArea()
        {
            var circle = new Circle(5);
            Assert.AreEqual(Math.PI * 25, circle.GetArea(), 1e-10);
        }

        [Test]
        public void Circle_WithNegativeRadius_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}
