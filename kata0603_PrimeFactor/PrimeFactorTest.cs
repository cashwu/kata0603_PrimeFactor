using NUnit.Framework;

namespace kata0603_PrimeFactor
{
    class PrimeFactorTest
    {
        private readonly PrimeFactor _primeFactor = new PrimeFactor();

        [Test]
        public void Input_1_return_empty()
        {
            Assert.AreEqual(new int[] {}, _primeFactor.GetPrimeFactor(1));
        }

        [Test]
        public void Input_2_return_2()
        {
            Assert.AreEqual(new [] {2}, _primeFactor.GetPrimeFactor(2));
        }

        [Test]
        public void Input_3_return_3()
        {
            Assert.AreEqual(new[] { 3 }, _primeFactor.GetPrimeFactor(3));
        }

        [Test]
        public void Input_4_return_2_and_2()
        {
            Assert.AreEqual(new[] { 2, 2 }, _primeFactor.GetPrimeFactor(4));
        }

        [Test]
        public void Input_6_return_2_and_3()
        {
            Assert.AreEqual(new[] { 2, 3 }, _primeFactor.GetPrimeFactor(6));
        }

        [Test]
        public void Input_8_return_2_2_and_2()
        {
            Assert.AreEqual(new[] { 2, 2, 2 }, _primeFactor.GetPrimeFactor(8));
        }

        [Test]
        public void Input_9_return_3_and_3()
        {
            Assert.AreEqual(new[] { 3, 3 }, _primeFactor.GetPrimeFactor(9));
        }

        [Test]
        public void Input_big_int()
        {
            Assert.AreEqual(new[] { 2, 2, 73, 79, 83, 83 }, _primeFactor.GetPrimeFactor(2* 2 * 73 * 79 * 83 * 83));
        }
    }
}
