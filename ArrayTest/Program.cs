using System;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraInteger = { 0,1,2,3,4,5,6,7,8,9};

            Console.WriteLine("Legth of array is :" +arraInteger.Length);

            var getElemet = arraInteger[6];
            Console.WriteLine($"Element of array at {getElemet} is :" + getElemet);

            var getType = arraInteger.GetType();
            Console.WriteLine("Type of array " +getType);

            //var getDataType = Console.ReadLine();
            //Console.WriteLine($"Type of {getDataType} is : {getDataType.GetType()}");

            Random r = new Random();
            int[] array = new int[10];
            var minValue = 0;
            var maxValue = 10;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(minValue, maxValue + 1);
                Console.WriteLine(array[i]);
            }
                //var count = array.Length;

                //Console.WriteLine(count);
           

        }
    }
}
