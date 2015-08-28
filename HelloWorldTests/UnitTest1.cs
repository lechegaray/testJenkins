using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;


namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {

            Assert.AreEqual("This better work, dear lord.", Program.CreateMessage());
        }
    }
}
