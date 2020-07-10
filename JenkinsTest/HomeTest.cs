using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsTest
{
    [TestClass]
    public class HomeTest
    {
        [TestMethod]
        public void IsIndexRunning()
        {
            var input = "RUNNING";

            Assert.AreEqual("RUNNING", input);
        }

        [TestMethod]
        public void IsServiceHealthy()
        {
            var input = "YES";

            Assert.AreEqual("YES", input);
        }
    }
}
