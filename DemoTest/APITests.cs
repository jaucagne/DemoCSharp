using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoTest
{
    [TestClass]
    public class APITests
    {
        [TestMethod]
        public void EqualityTest()
        {
            var test = 1;
            Assert.AreEqual(1, test);
        }
    }
}