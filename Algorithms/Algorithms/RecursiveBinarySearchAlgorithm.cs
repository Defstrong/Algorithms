

namespace Algorithms.Algorithms
{
    static public class RecursiveBinarySearchAlgorithm
    {
        static public (int idxFindVal, bool hereOrNo) RecursiveBinarySearch(this int[] array, int lowReturn, int highReturn, int findVal)
        {
            int low = lowReturn, high = highReturn;
            int middle = low + (high - low) / 2;
            if (low >= high)
                return (-1, false);
            if (array[middle] == findVal)
                return (middle, true);


            if (array[middle] < findVal)
                return array.RecursiveBinarySearch(middle + 1, high, findVal);
            else
                return array.RecursiveBinarySearch(low, middle, findVal);
        }
    }
}
