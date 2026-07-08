namespace LegacyCode.Test
{
    using NUnit.Framework;

    [TestFixture]

    public class ShippingCalculatorTest
    {
        [TestCase(1002, 36.8)]
        [TestCase(1003, 27.4)]
        [TestCase(1001, 2.5)]
        public void Dummy(int orderId, double expectedCost)
        {
            ShippingCalculator calculator = new();

            var actualCost = calculator.CalculateShipping(orderId);

            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}
