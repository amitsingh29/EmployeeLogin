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

        [Test]
        public void GivenNullTo_EqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Feet feet = new Feet();
            bool actual = feet.Equals(null);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenReferenceTo_EqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Feet feet = new Feet();
            bool actual = feet.Equals(feet);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenObjectType_WhenAnalyse_ReturnTrue()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(new Feet());
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenValueToFeetClass_WhenAnalyse_ReturnEqusl()
        {
            Feet feet = new Feet(5);
            int actual = feet.EqualsValue();
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenValueIn_InchClassEqualsValueFunction_WhenAnalyse_ReturnEqual()
        {
            Inch inch = new Inch(0);
            int actual = inch.Equalsvalue();
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenNullTo_InchClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Inch inch = new Inch();
            bool actual = inch.Equals(null);
            Assert.IsTrue(actual);
        }
    }
}