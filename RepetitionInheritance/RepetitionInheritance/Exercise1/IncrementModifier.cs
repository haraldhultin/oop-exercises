using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance.Exercise1
{
    class IncrementModifier : ArrayModifier
    {
        public IncrementModifier(int[] intArray) : base(intArray)
        {
        }

        protected override int ModifyValue(int num)
        {
            return num + 1;
        }
    }
}
