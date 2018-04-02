using System;

namespace QuickSort
{
    public class Program
    {
        public static void QuickSort(int[] array, int lowBorder, int upBorder)
        {
            if (upBorder == lowBorder || array.Length == 0) return;
            var pivot = array[upBorder];
            var storeIndex = lowBorder;
            for (int i = lowBorder; i < upBorder; i++)
                if (array[i] <= pivot)
                {
                    var swap1 = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = swap1;
                    storeIndex++;
                }
            var swap2 = array[storeIndex];
            array[storeIndex] = array[upBorder];
            array[upBorder] = swap2;
            if (storeIndex > lowBorder) QuickSort(array, lowBorder, storeIndex - 1);
            if (storeIndex < upBorder) QuickSort(array, storeIndex + 1, upBorder);
        }

        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}


