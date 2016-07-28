using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerach
{
    class BinarySearch
    {
        public  bool BinarySerach(List<int> intArray, int serachNumber)
        {

            intArray.Sort();
            int firstItem = intArray[0];
            int lastItem = intArray[intArray.Count - 1];

            while (firstItem <= lastItem)
            {

                int middleItem = intArray[(intArray.FindIndex(x => x == firstItem) + intArray.FindIndex(x => x == lastItem)) / 2];

                if (serachNumber == middleItem)
                    return true;
                if (serachNumber < middleItem)
                    lastItem = intArray[(intArray.FindIndex(x => x == firstItem) + intArray.FindIndex(x => x == lastItem)) / 2 - 1];
                else
                    firstItem = intArray[(intArray.FindIndex(x => x == firstItem) + intArray.FindIndex(x => x == lastItem)) / 2 + 1];
            }

            return false;

        }
    }
}
