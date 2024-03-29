﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArraysSample
    {
        public static void PrintArray(int[] numbers)
        {
            try
            {
                Array.Sort(numbers);
                for (int i = 0; i < numbers.LongLength; i++)
                {
                    //Console.WriteLine("Element[{0}] = {1}", i, numbers[i]);
                    Console.WriteLine(numbers[i]);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static void AccessingArrayElements()
        {
            int[] intArrya = new int[] { 2, 8, 9, 4, 6 };

            int[] n = new int[10]; /* n is an array of 10 integers */
            int i, j;

            /* initialize elements of array n */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1} {2}", j, n[j], j + 1);

            }
            Console.ReadKey();
        }
        public static void UsingtheforeachLoop()
        {
            int[] n = new int[10]; /* n is an array of 10 integers */

            /* initialize elements of array n */
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
            Console.ReadKey();
        }

        public static void MultiDimentionalArray()
        {
            /* an array with 5 rows and 2 columns*/
            int[,] a = new int[5, 2] { { 0, 0 },
                                       { 1, 2 },
                                       { 2, 4 },
                                       { 3, 6 },
                                       { 4, 8 }
                                        };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
            Console.ReadKey();

        }
        public static void JaggedArryay()
        {
            /* a jagged array of 5 array of integers*/
            int[][] a = new int[][]{new int[]{0,0},new int[]{1,2},
            new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };
            int i, j;


            int[][] ab = new int[][] {
                new int[]{1,2,3,4,5 },
                 new int[]{1,2,3,4},
                  new int[]{1,2,3,4},
                   new int[]{1,2,3 }


            };


            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
            Console.ReadKey();
        }

        public static void PassingArraytoFunction()
        {
            /* an int array with 5 elements */
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;

            /* pass pointer to the array as an argument */
            avg = GetAverage(balance, 5);

            /* output the returned value */
            Console.WriteLine("Average value is: {0} ", avg);
            Console.ReadKey();
        }
        private static double GetAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }

        public static int ParamsArray(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        public static void ArrayProps()
        {
            int[] arrayOfAge = new int[10];


            int[] list = { 34, 72, 13, 44, 25, 30, 10 };

            int[] temp = list;
            var result = Array.IndexOf(list, 44);
            list.SetValue(55, result);

            Console.Write("Original Array: ");
            var ascOrder = list.OrderBy(s => s);
            var descOrcer = list.OrderByDescending(s => s);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // reverse the array
            Array.Reverse(temp);
            Console.Write("Reversed Array: ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //sort the array
            Array.Sort(list);
            Console.Write("Sorted Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class Program
    {
        public readonly int[] redArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        static void Main(string[] args)
        {

            ArraySample _ArraySample = new ArraySample();
            _ArraySample.Route();


            int[] arryaNumbers2 = new int[] { 8749, 98, 8, 7, 41, 9, 4784, 9849, 844984, 94984, 984, 4194, 984, 9, 4 };



            Array.Sort(arryaNumbers2);

            Array.Reverse(arryaNumbers2);






            int[] arrayFixedSize = new int[10];

            int[] sampleArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[,] multiDimentional = new int[,] {
                { 1,2,3},
                { 4,5,6},
                {7,8,9 }
            };
            var put = Array.IndexOf(sampleArray, 4);
            sampleArray.SetValue(50, put);
            Array.Reverse(sampleArray);
            int[][] jaggedArray = new int[][] {
                new int[]{ 1,2,3},
                new int[]{ 4,5,6},
                new int[]{ 1,2,3},
                new int[]{ 1,2,3},
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(multiDimentional[i, j]);
                }
            }
            for (int i = 0; i < 20; i++)
            {
                sampleArray[i] = i + 100;
            }
            ArraysSample.ArrayProps();
            int number = 0;
            int[] numArray = new int[] { 10, 20 };

            int[,] multiDimention = new int[,] { { 1, 2 }, { 3, 4 }, { 3, 4 } };
            var result = multiDimention[1, 1];


            int[] arryaNumbers = new int[] { 8749, 98, 8, 7, 41, 9, 4784, 9849, 844984, 94984, 984, 4194, 984, 9, 4 };
            ArraysSample.PrintArray(arryaNumbers);
        }
    }
}
