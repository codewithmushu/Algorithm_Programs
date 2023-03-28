using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class InsertionSort
    {
        public void DisplayInsertion()
        {
            int[] arr = new int[5] {23, 9, 10, 34, 4};
            int n = 5, i, j, val, flag;
            Console.WriteLine("Insertion Sort");

            Console.WriteLine("Initial Array");
            for(i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            for(i = 0; i < n;i++)
            {
                val = arr[i];
                flag = 0;
                for(j = i-1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j+1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }

            Console.WriteLine("Sorted Array ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
