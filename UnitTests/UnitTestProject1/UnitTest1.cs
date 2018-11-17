using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        TriangleTest.CheckTriangle triangle = new TriangleTest.CheckTriangle();
        [TestMethod]
        public void AreAllSidesEqual()
        {
            Assert.AreEqual(true, triangle.TriangleTest(10, 10, 10));
        }
        [TestMethod]
        public void AreTwoSidesEqual()
        {
            Assert.AreEqual(true, triangle.TriangleTest(8, 8, 9));
        }
        [TestMethod]
        public void AreAllSidesEqualZero()
        {
            Assert.AreEqual(false, triangle.TriangleTest(0, 0, 0));
        }
        [TestMethod]
        public void IsOneSideEqualZero()
        {
            Assert.AreEqual(false, triangle.TriangleTest(10, 6, 0));
        }
        [TestMethod]
        public void IsOneSideEqualNegativeValue()
        {
            Assert.AreEqual(false, triangle.TriangleTest(7.45, -5, 1.2));
        }
        [TestMethod]
        public void IsOneSideEqualDecimalValue()
        {
            Assert.AreEqual(true, triangle.TriangleTest(2.56, 0b1110, 89));
        }
        [TestMethod]
        public void IsOneSideEqualHexValue()
        {
            Assert.AreEqual(true, triangle.TriangleTest(2.56, 0b1110, 0xf100));
        }
        [TestMethod]
        public void AreAllSidesEqualMaxDoubleValue()
        {
            Assert.AreEqual(false, triangle.TriangleTest(double.MaxValue, double.MaxValue, double.MaxValue));
        }
        [TestMethod]
        public void AreAllSidesEqualMinDoubleValue()
        {
            Assert.AreEqual(false, triangle.TriangleTest(double.MinValue, double.MinValue, double.MinValue));
        }
        [TestMethod]
        public void AreTwoSidesEqualNaNValue()
        {
            Assert.AreEqual(false, triangle.TriangleTest(double.NaN, 1.2, double.NaN));
        }
    }
}
