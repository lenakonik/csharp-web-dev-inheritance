using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;


namespace TechnologyTests
{
    [TestClass]
    public class ComputerTest
    {
        Computer test_computer;

        [TestInitialize]
        public void CreateComputerObject()
        {
            test_computer = new Computer(8, 256, true);
        }

        //constructor should set ram properly
        [TestMethod]
        public void TestInitialRam()
        {
            Assert.AreEqual(8, test_computer.Ram, .001);
        }

        //constructor should set storage properly
        [TestMethod]
        public void TestInitialStorage()
        {
            Assert.AreEqual(256, test_computer.Storage, .001);
        }

        // Test increase ram 
        [TestMethod]
        public void TestIncrementRam()
        {
            test_computer.IncreaseRam(8);
            Assert.AreEqual(16, test_computer.Ram, .001);
        }

        // Test Id
        [TestMethod]
        public void TestInheritsId()
        { 
            Assert.AreEqual(1, test_computer.Id);
            Computer test_computer2 = new Computer(4, 6, true);
            Assert.AreEqual(2, test_computer2.Id);
        }

    }
}
