using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Feet
    {
        private int feet;
        private object obj;

        public Feet()
        {
        }

        public Feet(object obj)
        {
            this.obj = obj;
        }
        public Feet(int feet)
        {
            this.feet = feet;
        }

        public int EqualsValue()
        {
            return this.feet;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj))
                return true;

            return false;
        }
    }
}
