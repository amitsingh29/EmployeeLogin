using NUnit.Framework;
using QuantityMeasurement;

namespace QuantityMeasurementTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenValueIn_FeetClassEqualsValueFunction_WhenAnalyse_ReturnEqual()
        {
            Feet feet = new Feet(0);
            int actual = feet.EqualsValue();
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

    }
}