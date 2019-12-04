using System;
using System.Collections.Generic;

namespace LiveCoding3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Arrays length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr1 = new int[length];
            int[] arr2 = new int[length];

            Console.WriteLine("Input array: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i+1}: ");
                arr1.SetValue(int.Parse(Console.ReadLine()),i);
            }

            Console.WriteLine("Input array: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i + 1}: ");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] result = new int[length * 2];

            int a = 0;
            for(int i=0; i<length; i++)
            {
                result[a] = arr1[i];
                a++;
                result[a] = arr2[i];
                a++;
            }

            foreach(int value in result)
            {
                Console.Write(value);
            }

        }
    }
}
