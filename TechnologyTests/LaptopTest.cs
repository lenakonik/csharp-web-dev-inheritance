using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;


namespace TechnologyTests
{
    [TestClass]
    public class LaptopTest
    {
        Laptop test_laptop;

        [TestInitialize]
        public void CreateLaptopObject()
        {
            test_laptop = new Laptop(8, 256, true, 3);
        }

        //constructor should set ram properly
        [TestMethod]
        public void TestInitialRam()
        {
            Assert.AreEqual(8, test_laptop.Ram, .001);
        }

        //constructor should set weight properly
        [TestMethod]
        public void TestInitialStorage()
        {
            Assert.AreEqual(3, test_laptop.Weight, .001);
        }

        // Test IsHeavy
        [TestMethod]
        public void TestIsHeavy()
        {
            Assert.IsFalse(test_laptop.isHeavy());
        }

        // Test Increasing Laptop Ram - initial and increased
        [TestMethod]
        public void TestIncreasingRam()
        {
            Assert.AreEqual(8, test_laptop.Ram);
            test_laptop.IncreaseRam(4);
            Assert.AreEqual(12, test_laptop.Ram);
        }

        [TestMethod]
        public void TestInheritingBaseConstructor()
        {
            Assert.IsNotNull(test_laptop.Id);
        }

    }
}
