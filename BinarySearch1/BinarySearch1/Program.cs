using System;
namespace ConsoleApplication
{
    class Program
    {
        public static int BinarySearch(int[] array, int value)
        {
            if (array.Length == 0) return -1;
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var middle = (right + left) / 2;
                if (value <= array[middle])
                    right = middle;
                else left = middle + 1;
            }
            if (array[right] == value)
                return right;
            return -1;

        }
        //код поиска значения value в массиве array
        static void Main(string[] args)
        {
            TestNegativeNumbers();
            TestNonExistentElement();
            TestRepeatNumbers();
            TestEmptyNumbers();
            TestVastNumbers();
            TestOneNumber();
            Console.ReadKey();
        }
        private static void TestNegativeNumbers()
        {            //Тестирование поиска в отрицательных числах
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -7, -2}");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }
        private static void TestNonExistentElement()
        {            //Тестирование поиска отсутствующего элемента
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат работает корректно");
        }
        private static void TestRepeatNumbers()
        {            //Тестирование поиска элемента, повторяющегося несколько раз
            int[] repeatNumbers = new[] { 3, 3, 1, 3, 3 };
            var ind = BinarySearch(repeatNumbers, 3);
            if (repeatNumbers[ind] != 3)
                Console.WriteLine("! Поиск нашёл число 5 среди чисел {3, 3, 1, 3, 3}");
            else
                Console.WriteLine("Поиск среди элементов, повторяющихся несколько раз работает корректно");
        }
        private static void TestEmptyNumbers()
        {            //Тестирование поиска элемента в пустом массиве 
            int[] emptyNumbers = { };
            if (BinarySearch(emptyNumbers, 5) != -1)
                Console.WriteLine("! Поиск нашёл число 5 среди чисел {}");
            else
                Console.WriteLine("Поиск элементов в пустом массиве работает корректно");
        }
        private static void TestVastNumbers()
        {         //Тестирование поиска элемента в массиве из 1001 элемента 
            var vastNumbers = new int[100001];
            for (var i = 0; i < 100001; i++)
                vastNumbers[i] = i - 10;
            for (var i = 0; i < 100001; i++)
            {
                var ind = BinarySearch(vastNumbers, i);
                if (vastNumbers[ind] != i)
                    Console.WriteLine("! Поиск не нашёл число i среди 100001 элементов");
                else
                    Console.WriteLine("Поиск элементов в массиве из 100001 элемента работает корректно");
                return;
            }
        }
        private static void TestOneNumber()
        {            //Тестирование поиска одного элемента
            int[] oneNumber = new[] { 1, 2, 3, 5, 7 };
            if (BinarySearch(oneNumber, 3) != 2)
                Console.WriteLine("! Поиск не нашёл число 3 среди чисел { 1, 2, 3, 5, 7 }");
            else
                Console.WriteLine("Поиск одного элемента в массиве  работает корректно");


        }
    }
}

