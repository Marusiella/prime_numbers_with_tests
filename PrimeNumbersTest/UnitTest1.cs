using PrimeNumbers;

namespace PrimeNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckSimpleFive()
        {
            PrimeNumbers.PrimeNumbers p = new();
            List<int> list = new() { 2, 3, 5, 7 };
            Assert.AreEqual(String.Join(", ", list), String.Join(", ", p.GetNumbers()));
        }
        [TestMethod]
        public void CheckOwnFive()
        {
            PrimeNumbers.PrimeNumbers p = new() { Start = 2, End = 20};
            List<int> list = new() { 2, 3, 5, 7,11,13,17,19 };
            Assert.AreEqual(String.Join(", ", list), String.Join(", ", p.GetNumbers()));
        }
    }
}