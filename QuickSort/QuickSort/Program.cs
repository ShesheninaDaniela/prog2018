using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuickSort
{
   public class Program
    {    
        public static int Partition(int[] array, int lowBorder, int upBorder)

        {
            int marker = lowBorder;
            int swapMarker;
            for (int i = lowBorder; i <= upBorder; i++) 
            {
                if (array[i] < array[upBorder])
                {
                    swapMarker = array[marker];
                    array[marker] = array[i];
                    array[i] = swapMarker;
                    marker += 1;
                }
            }
            swapMarker = array[marker];
            array[marker] = array[upBorder];
            array[upBorder] = swapMarker;
            return marker;
        }
        public static void QuickSort(int[] array, int lowBorder, int upBorder)
        {
            if (lowBorder >= upBorder)
            {
                return;
            }
            int partingElement = Partition(array, lowBorder, upBorder);
            QuickSort(array, lowBorder, partingElement - 1);
            QuickSort(array, partingElement + 1, upBorder);
        }
        static void Main(string[] args)
        {

        }
    }
}

