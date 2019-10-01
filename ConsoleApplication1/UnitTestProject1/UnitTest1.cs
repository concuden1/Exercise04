using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using UnitTestProject1;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);
        }

        public void TestIsEven()
        {
            bool result4 = Program.IsEven(4);
            Assert.AreEqual(true, result4);

            bool result3 = Program.IsEven(3);
            Assert.AreEqual(false, result3);
        }

        public void TestIsPrime()
        {
            bool result2 = Program.IsPrime(2);
            Assert.AreEqual(true, result2);

            bool result4 = Program.IsPrime4);
            Assert.AreEqual(false, result4);
        }
        [TestMethod]
        public void TestCeil()
        {
            int result1 = Program.Ceil((float)2.3);
            Assert.Arequal(3, result1);
            int result2 = Program.Ceil(-2.3f);
            Assert.Arequal(-2, result2);
        }
        [TestMethod]
        public void TestFloat()
        {
            int result1 = Program.Float((float)2.3);
            Assert.Arequal(2, result1);
            int result2 = Program.Float(-2.3f);
            Assert.Arequal(-3, result2);
        }


    }
}