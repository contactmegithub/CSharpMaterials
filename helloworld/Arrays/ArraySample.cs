using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ArraySample
    {
        public void SingleDimentionalArray()
        {
            int[] numberGroups = new int[10];
            int[] numberGroups2 = new int[] { 34, 45, 23, 46, 46, 34, 245, 6345, 636, 6, 345, 346363, 56, 6436, 37, 324636, 6 };
            var result = numberGroups2[2];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                numberGroups[i] = rand.Next(0, 100);
            }
            Array.Clear(numberGroups, 0, 5);

            var indexOf = Array.IndexOf(numberGroups2, 346363);
            Array.Reverse(numberGroups2);
            numberGroups2.SetValue(100, 0);
            Array.Sort(numberGroups2);
            Array.Reverse(numberGroups2);


      
            for (int i = 0; i < numberGroups2.Length; i++)
            {
                Console.WriteLine(numberGroups2[i]);
            }

            var arrayRank = numberGroups2.Rank;
        }

        public void MultiDimentioalArray()
        {
            int[,] numberGroups = new int[10, 10];

            int[,] numberGroups2 = new int[,]
            {
                {1,2,3,4,5 },
                {6,7,8,9,10 },
                {11,12,13,14,15 },
                {16,17,18,19,20},
            };
            var arrayRank = numberGroups2.Rank;




            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(numberGroups2[i, j]);
                }
            }
        }

        public void JaggedArray()
        {
            int[][] numberGroups = new int[10][];
            int[][] numberGroups2 = new int[][]
            {
                 new int[]{1,2,3,4,5 },
                 new int[]{6,7,8 },
                 new int[]{11,12,13,14,15 },
                 new int[]{16},
            };

        }

        public void Route()
        {
            while (true)
            {
                SingleDimentionalArray();
                MultiDimentioalArray();
                JaggedArray();
            }
        }
    }
}
