using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace QuikSort.Tests
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void Test3Elements()
        {
            
            int[] threeElementsArray = new[] { 10, 5, 7 };
            Program.QuickSort(threeElementsArray);
            Assert.IsTrue(threeElementsArray[0] <= threeElementsArray[1], "Второй элемент должен быть больше первого");
            Assert.IsTrue(threeElementsArray[1] <= threeElementsArray[2], "Третий элемент должен быть больше второго");
        }

        [TestMethod]
        public void Test100EqualElements()
        {
            
            int[] equalNumbers = new int[100];
            for (int i = 0; i < equalNumbers.Length; i++)
                equalNumbers[i] = 14;
            Program.QuickSort(equalNumbers);
        }

        [TestMethod]
        public void Test1000RandomElements()
        {
                  
            int[] randomNumbers = new int[1000];
            var rnd = new Random();
            for (int i = 0; i < randomNumbers.Length; i++)
                randomNumbers[i] = rnd.Next();
            Program.QuickSort(randomNumbers);
            for (int i = 0; i < 10; i++)
            {
                int index = rnd.Next(0, 999);
                Assert.IsTrue(randomNumbers[index] <= randomNumbers[index + 1], "В паре большим должен быть тот элемент, чей индекс больше");
            }
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            
            int[] emptyArray = new int[0];
            Program.QuickSort(emptyArray);
        }

        [TestMethod]
        public void TestBigArray()
        {          
            int[] bigArray = new int[1500000000];
            var rnd = new Random();
            for (int i = 0; i < bigArray.Length; i++)
                bigArray[i] = rnd.Next();
            Program.QuickSort(bigArray);
        }
    }
}
