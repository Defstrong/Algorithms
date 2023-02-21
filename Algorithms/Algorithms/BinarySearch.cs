using System;

namespace Algorithms.Algorithms
{
    static public class BinarySearchAlgorithm
    {
        static public (int idxFindVal, bool haveOrNot) BinarySearch(this int[] array, int findVal)
        {
            int low = 0;
            int high = array.Length - 1, middle = (low + high) / 2;
            while ((array[middle] != findVal) && low <= high)
            {
                middle = (low + high) / 2;

                if (array[middle] < findVal)
                    low = middle + 1;
                else if (array[middle] > findVal)
                    high = middle - 1;
            }
            if (array[middle] == findVal)
                return (middle, true);
            return (middle, false);
        }
    }
}
