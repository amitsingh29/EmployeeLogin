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
            UnitCheck feet = new UnitCheck(0);
            int actual = feet.CheckLength();
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
            UnitCheck feet = new UnitCheck(0);
            int actual = feet.CheckLength();
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenValueIn_InchClassEqualsValueFunction_WhenAnalyse_ReturnEqual()
        {
            UnitCheck inch = new UnitCheck(0);
            int actual = inch.CheckLength();
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

        [Test]
        public void GivenReferenceTo_InchClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Inch inch = new Inch();
            bool actual = inch.Equals(inch);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenObjectTo_InchClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Inch inch = new Inch();
            bool actual = inch.Equals(new Inch());
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenValueTo_InchClass_WhenAnalyse_ReturnEqual()
        {
            UnitCheck inch = new UnitCheck(10);
            int actual = inch.CheckLength();
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test11()
        {
            Inch inch = new Inch(15);
            Feet feet = new Feet(15);
            int actual = inch.CheckInch_Value();
            int expected = feet.CheckFeet_Value();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Compare_1ft_Not_Equal_to_1inch_return_False()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            int expected = feet.EqualsValue();
            UnitCheck inch = new UnitCheck("Inch", 1);
            int actual = inch.EqualsValue();
            Assert.AreEqual(expected, actual);
        }
    }
}