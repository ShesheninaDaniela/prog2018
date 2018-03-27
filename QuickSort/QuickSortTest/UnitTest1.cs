using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSortTest;

namespace QuickSortTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void arrayOfThreeElements()
        {
            int[] three = new int[3] { -1, -2, -3 };
            Program.QuickSort(three, 0, 2);

            int[] expectedArray = new int[] { -3, -2, -1 };

            for (int i = 0; i < expectedArray.Length; i++)
                Assert.AreEqual(expectedArray[i], three[i]);
        }
        [TestMethod]
        public void arrayOf100Elements()
        {
            int[] elements = new int[100];
            for (int i = 0; i < 99; i++)
                elements[i] = 0;

            int[] expectedArray = new int[100];
            for (int i = 0; i < 99; i++)
                expectedArray[i] = 0;

            Program.QuickSort(elements, 0, 99);

            for (int i = 0; i < expectedArray.Length; i++)
                Assert.AreEqual(expectedArray[i], elements[i]);
        }
        public void arrayOf1000Elements()
        {
            var rnd = new Random();
            int[] randomElements = new int[1000];
            for (int i = 0; i < 1000; i++)
                randomElements[i] = rnd.Next();

            Program.QuickSort(randomElements, 0, 999);

            for (int i = 0; i < 10; i++)
            {
                int checkElement = rnd.Next(0, 998);
                Assert.IsTrue(randomElements[checkElement] < randomElements[checkElement + 1]);
            }
        }
        [TestMethod]
        public void emptyArray()
        {
            int[] emptyArray = new int[] { };

            Program.QuickSort(emptyArray, 0, 0);
        }
        [TestMethod]
        public void arrayOf1500000000Elements()
        {
            var rnd = new Random();
            int[] randomElements = new int[200000000];
            for (int i = 0; i < randomElements.Length; i++)
                randomElements[i] = rnd.Next();

            Program.QuickSort(randomElements, 0, randomElements.Length - 1);

            for (int i = 0; i < 10; i++)
            {
                int checkElement = rnd.Next(0, randomElements.Length - 2);
                Assert.IsTrue(randomElements[checkElement] < randomElements[checkElement + 1]);
            }
        }
    }
}
