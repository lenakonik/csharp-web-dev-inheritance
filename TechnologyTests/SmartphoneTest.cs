using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;


namespace TechnologyTests
{
    [TestClass]
    public class SmartphoneTest
    {
        Smartphone test_smartphone;

        [TestInitialize]
        public void CreateLaptopObject()
        {
            test_smartphone = new Smartphone(6, 32, true);
        }

        // Test Increasing Smartphone Ram - initial and increased
        [TestMethod]
        public void TestIncreasingRam()
        {
            Assert.AreEqual(6, test_smartphone.Ram);
            test_smartphone.IncreaseRam(4);
            Assert.AreEqual(10, test_smartphone.Ram);
        }

        //Test taking selphies
        [TestMethod]
        public void TestSelphie()
        {
            test_smartphone.MakeSelphie();
            Assert.AreEqual(1, test_smartphone.numberOfSelphies);
        }

    }
}
