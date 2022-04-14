using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    internal class Program
    {
        static void InsertionSort(int []arr)
        {
            for(int i=1;i<arr.Length;i++)
            {
                int index = 0, flag = 0, val = arr[i];
                for(int j=i;j>0;j--)
                {
                    if(val<arr[j-1])
                    {
                        arr[j] = arr[j - 1];
                        index = j - 1;
                        flag = 1;
                    }
                }
                if (flag == 1)
                    arr[index] = val;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
        static void Main(string[] args)
        {
            InsertionSort(new int[] { 3, 2, 1, 4, 5, 8, 4, 5 });
            InsertionSort(new int[] { 3, 0, 1, -1, 5, });
            InsertionSort(new int[] { 0, 0, 1, -1, 0, });
            Console.ReadLine();
        }
    }
}
