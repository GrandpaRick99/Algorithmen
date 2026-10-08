using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmen
{
    public class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
           
                int smallest = i;
                for (int j = 0 + i; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                        smallest = j;

                }
                smallest = smallest;
                int temp = array[i];
                array[i] = array[smallest];
                array[smallest] = temp;
            }
            return array;
        }
    }
}
