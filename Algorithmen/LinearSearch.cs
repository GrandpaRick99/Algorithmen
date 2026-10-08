using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmen
{
    public class LinearSearch
    {
        public static int Search(int[] array, int target)
        {
            for(int i = 0; i<array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }                
                  
            }
            return -1;

        }
    }
}
