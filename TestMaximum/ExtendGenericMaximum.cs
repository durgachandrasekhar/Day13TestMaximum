using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumNumber
{
    class ExtendGenericMaximum<T> where T : IComparable
    {
        public T[] value;

        //Parameter Constructor
        public ExtendGenericMaximum(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

    }
}