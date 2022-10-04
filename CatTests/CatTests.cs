using Cats;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatTests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        //It’s a good practice to test subclasses to verify the items that they inherit or override
        public void InheritsBaseInFirstConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
            Assert.AreEqual(7, keyboardCat.Weight, .001);
        }

        [TestMethod]
        public void InheritsDefaultCatInSecondConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat");
            Assert.AreEqual(13.0, keyboardCat.Weight, .001);
        }

        [TestMethod]
        public void IsNotInitiallyTired()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat");
            Assert.IsFalse(keyboardCat.Hungry);
            Assert.IsFalse(keyboardCat.Tired);
            keyboardCat.Eat();
            Assert.IsTrue(keyboardCat.Tired);
        }
    }
}
