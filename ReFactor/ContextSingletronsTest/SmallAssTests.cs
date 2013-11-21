using ContextSingletons.Models.Donkey;
using NUnit.Framework;

namespace ContextSingletronsTest
{
    [TestFixture]
    public class SmallAssTests
    {
        [Test]
        public void A_Default_SmallAss_Should_Be_Able_Carry_30_KG()
        {
            var smallAss = new SmallAss(new FakeContext());

            int result = smallAss.CarryingCapacity();

            int expected = 30;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Two_SmallAsses_With_Different_Leg_Counts_Should_Return_Different_Capacities()
        {
            var firstSmallAss = new SmallAss(new FakeContext());
            var secondSmallAss = new SmallAss(new FakeContext(), 3);
            int secondResult = secondSmallAss.CarryingCapacity();
            int firstResult = firstSmallAss.CarryingCapacity();

            int secondExpected = 15;
            int firstExpected = 30;
            Assert.AreEqual(secondExpected, secondResult);
            Assert.AreEqual(firstExpected, firstResult);
        }

    }
}