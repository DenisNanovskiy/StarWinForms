using NUnit.Framework;
using Star.Models;
using System;
using System.Drawing;

namespace Star.Tests
{
    [TestFixture]
    class Tests
    {
        [TestCase(50, 25, 10, 10, 0.12, 24)]
        [TestCase(26, 25, 0, 0, 0, 5)]
        public void TestCreateValidStar(double largeRadius, double smallRadius, float centerCoodinatesX, float centerCoodinatesY, double degree, int raysNumber)
        {
            var star = new StarModel(largeRadius, smallRadius, new PointF(centerCoodinatesX, centerCoodinatesY), degree, raysNumber);
            Assert.IsNotNull(star);
            Assert.IsTrue(star.Tops.Count == star.RaysNumber * 2);
        }

        [TestCase(24, 25, 10, 10, 0, 5)]
        [TestCase(50, 25, 10, 10, 0, 4)]
        public void TestCreateNotValidStar(double largeRadius, double smallRadius, float centerCoodinatesX, float centerCoodinatesY, double degree, int raysNumber)
        {
            Assert.Throws(typeof(Exception), () =>
            {
                var star = new StarModel(largeRadius, smallRadius, new PointF(centerCoodinatesX, centerCoodinatesY), degree, raysNumber);
            });
        }
    }
}
