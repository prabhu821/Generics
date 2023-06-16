using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericMaximum<Type> where Type : IComparable
    {
        public Type value1;
        public Type value2;
        public Type value3;
        public Type value4;


        public GenericMaximum(Type value1, Type value2, Type value3, Type value4)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
            this.value4 = value4;
        }

        public Type GetMax()
        {
            Type max = value1;
            if (value2.CompareTo(max) > 0)
            {
                max = value2;
            }
            if (value3.CompareTo(max) > 0)
            {
                max = value3;
            }
            if (value4.CompareTo(max) > 0)
            {
                max = value4;
            }
            return max;
        }
    }
}
