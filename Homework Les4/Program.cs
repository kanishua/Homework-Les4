 using System;

namespace Homework_Les4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-20, 20);
                if (random.Next(0, 3) == 0)
                {
                    array[i] = 0;
                }
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("1.Find the minimum element of an array:");
            Console.WriteLine(FindMinElement(array));
            Console.WriteLine("2.Find the maximum element of an array:");
            Console.WriteLine(FindMaxElement(array));
            Console.WriteLine("3.Find the index of the minimum element of the array:");
            Console.WriteLine(FindIndexMinElement(array));
            Console.WriteLine("4.Find the index of the maximum element of the array:");
            Console.WriteLine(FindIndexMaxElement(array));
            Console.WriteLine("5.Calculate the sum of array elements with odd indices:");
            Console.WriteLine(FindSumElementsWithOddIndex(array));
            Console.WriteLine("6.Make an array reverse (an array in the opposite direction):");
            MakeReverseArray(array);
            PrintArray(array);
            Console.WriteLine("7.Count the number of odd array elements:");
            Console.WriteLine(CountNumberOddElements(array));
           
            Console.WriteLine("8.Swap the first and second half of the array:");
            SwapPlaceHalfArray(array);
            PrintArray(array);
            Console.WriteLine("9.Sort the array in ascending order in bubble way:");
            SortArrayByBubble(array);
            PrintArray(array);
            
            Console.WriteLine("10.Sort the array in descending order in inserts way");
            SortArrayByInsert(array);
            PrintArray(array);

        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
        
        //1.Find the minimum element of an array.
        private static int FindMinElement(int[] array)
        {
            int minElement = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                }
            }

            return minElement;
        }

        //2.Find the maximum element of an array.
        private static int FindMaxElement(int[] array)
        {
            int maxElement = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }

            return maxElement;
        }

        //3.Find the index of the minimum element of the array.
        private static int FindIndexMinElement(int[] array)
        {
            int minElement = array[0];
            int indexMinElement = default;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                    indexMinElement = i;
                }
            }

            return indexMinElement;
        }

        //4.Find the index of the maximum element of the array.
        private static int FindIndexMaxElement(int[] array)
        {
            int maxElement = array[0];
            int indexMaxElement = default;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    indexMaxElement = i;
                }
            }

            return indexMaxElement;
        }

        //5.Calculate the sum of array elements with odd indices.
        private static int FindSumElementsWithOddIndex(int[] array)
        {
            int sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        //6.Make an array reverse (an array in the opposite direction)
        private static void MakeReverseArray(int[] array)
        {
            for (int i = 0; i < (array.Length / 2); i++)
            {
                Swap(ref array[i], ref array[(array.Length - 1) - i]);
            }
        }

        //7.Count the number of odd array elements.
        private static int CountNumberOddElements(int[] array)
        {
            int numberOddElements = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    numberOddElements += 1;
                }
            }

            return numberOddElements;
        }

        //8.Swap the first and second half of the array, for example, for an array of 1 2 3 .
        private static void SwapPlaceHalfArray(int[] array)
        {
            for (int i = 0; i < (array.Length / 2); i++)
            {
                if (array.Length % 2 == 0)
                {
                    Swap(ref array[i], ref array[((array.Length / 2) + i)]);
                }
                else
                {
                    Swap(ref array[i], ref array[((array.Length / 2) + 1) + i]);
                }
            }
        }
    
        //9.Sort the array in ascending order in one of the ways:
        //bubble (Bubble), selection (Select) or inserts (Insert))
        private static void SortArrayByBubble(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
        
        //10.Sort the array in descending order in one of the ways
        //(different from the method in the 9th task):
        //bubble (Bubble), selection (Select) or inserts (Insert))
        private static void SortArrayByInsert(int[] array)
        {
            int j;
            int x;
            for (int i = 1; i < array.Length; i++)
            {
                j = i;
                x = array[i];
                while (j>0 && (x > array[j - 1]))
                {
                    Swap(ref array[j], ref array[j - 1]);
                    j -= 1;
                }
                array[j] = x;
            }
        }
    }
}
