using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace lab3unit
{
    [TestFixture]
    class UnitTests
    {
        [Test]
        public void Test1()
        {
            CheckTriangle triangle = new CheckTriangle();
            Assert.IsTrue(triangle.IsTriangle(1, 2, 3));
        }

        [Test]
        public void Test2()
        {
            CheckTriangle triangle = new CheckTriangle();
            Assert.IsTrue(triangle.IsTriangle(3, 4, 5));
        }

        [Test]
        public void Test3()
        {
            CheckTriangle triangle = new CheckTriangle();
            Assert.IsFalse(triangle.IsTriangle(0, 1, 0));
        }

        [Test]
        public void Test4()
        {
            CheckTriangle triangle = new CheckTriangle();
            Assert.IsFalse(triangle.IsTriangle(4.4, 5.2, 0.2));
        }

        [Test]
        public void Test5()
        {
            CheckTriangle triangle = new CheckTriangle();
            Assert.IsFalse(triangle.IsTriangle(4.9, 0, 5));
        }

        [Test]
        public void Test6()
        {
            CheckTriangle triangle = new CheckTriangle();
            Assert.IsFalse(triangle.IsTriangle(123, 145, 234));
        }

        [Test]
        public void Test7()
        {
            CheckTriangle triangle = new CheckTriangle();
            Assert.IsFalse(triangle.IsTriangle(-3567, 12344, -1235));
        }

        [Test]
        public void Test8()
        {
            CheckTriangle triangle = new CheckTriangle();
            Assert.IsFalse(triangle.IsTriangle(0.1233, 0.3445, 0.123));
        }

        [Test]
        public void Test9()
        {
            CheckTriangle triangle = new CheckTriangle();
            Assert.IsFalse(triangle.IsTriangle(111, 444, 555));
        }

        [Test]
        public void Test10()
        {
            CheckTriangle triangle = new CheckTriangle();
            Assert.IsFalse(triangle.IsTriangle(-1, -1, 1));
        }
    }
}
