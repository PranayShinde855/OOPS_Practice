using System;

namespace Code.Practice
{
    class RandmomValuesPractice
    {
        public void TestRamdom()
        {
            Random testRandom = new Random();

            int[] arrayTest = new int[10];
            int minValue = 0;
            int maxValue = 10;

            for (int i = 0; i < arrayTest.Length; i++)
                arrayTest[i] = testRandom.Next(minValue, maxValue + 1);

            for (int i = 0; i < arrayTest.Length; i++)
            {
                Console.WriteLine("" + arrayTest[i]);
            }
        }

        public static void main(string[] args)
        {
            Random testRandom = new Random();

            //int[] arrayTest = new int[10];
            //int minValue = 0;
            //int maxValue = 10;

            //for (int i = 0; i <= arrayTest.Length; i++)
            //    arrayTest[i] = testRandom.Next(minValue, maxValue + 1);

            //for (int i = 0; i < arrayTest.Length; i++)
            //    Console.WriteLine("" + arrayTest[i]);
        }
    }
}
