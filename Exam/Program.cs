using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] one = ReadArrayValues(3, "Enter values for array 1:");
            int[] two = ReadArrayValues(5, "Enter values for array 2:");

            int[] three = MergeArrays(one, two);

            Console.WriteLine(string.Join("\t", three));
            Console.ReadLine();
        }

        static int[] ReadArrayValues(int size, string message)
        {
            int[] array = new int[size];
            Console.WriteLine(message);
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        static int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            int array1Index = 0;
            int array2Index = 0;

            for (int i = 0; i < mergedArray.Length; i++)
            {
                if (i % 2 == 0 && array2Index < array2.Length)
                {
                    mergedArray[i] = array2[array2Index++];
                }
                else if (array1Index < array1.Length)
                {
                    mergedArray[i] = array1[array1Index++];
                }
                else
                {
                    mergedArray[i] = array2[array2Index++];
                }
            }

            return mergedArray;
        }
    }

}
