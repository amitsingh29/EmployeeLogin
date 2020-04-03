using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class UnitCheck
    {
        private int length;
        private string unit_type;

        public UnitCheck()
        {
        }

        public UnitCheck(int length)
        {
            this.length = length;
        }

        public UnitCheck(string unit_type, int length)
        {
            this.unit_type = unit_type;
            this.length = length;
        }

        public int CheckLength()
        {
            return this.length;
        }

        public UnitCheck(string type)
        {
            this.unit_type = type;
        }

        public int EqualsValue()
        {
            return this.length;
        }

        public int ConvertFeetToInch()
        {
            return this.length * 12;
        }

        public double ConvertInchToFeet()
        {
            return this.length / 12;
        }
    }
}
