using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance.Exercise1
{
    abstract class ArrayModifier
    {
        private int[] _intArray;
        public ArrayModifier(int[] intArray)
        {
            _intArray = intArray;
        }
        protected abstract int ModifyValue(int num);
        public void Modify()
        {
            for (int i = 0; i<_intArray.Length; i++)
            {
                int temp = ModifyValue(_intArray[i]);
                _intArray[i] = temp;
            }
            foreach (var item in _intArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
