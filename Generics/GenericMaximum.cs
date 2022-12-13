using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericMaximum<T> where T : IComparable
    {
        public T[] value;
        
        public GenericMaximum(T[] value)
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
            var sorted_values=Sort(values);
            return sorted_values[^1];
        }

        
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        //PRINT MAX VALUE
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
