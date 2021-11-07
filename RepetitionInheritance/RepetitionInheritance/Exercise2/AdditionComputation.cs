using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance.Exercise2
{
    class AdditionComputation : IComputation
    {
        public bool CanCompute(string str)
        {
            return (str == "+" || str == "plus");
        }

        public int Compute(int[] intArray)
        {
            int sum = 0;
            foreach (var element in intArray)
            {
                sum += element;
            }
            return sum;
        }
    }
}
