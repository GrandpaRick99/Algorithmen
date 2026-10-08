using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmen
{
    public class InsertionSort
    {
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++) //0,1, 2
            {
                
                    int temp = array[i];
                    for (int j = i - 1; j >= 0; j--) //-1,0,1

                        if (array[j]>temp)
                        {
                            array[j+1] = array[j];
                            
                        }
                        else
                        {
                            array[j+1]= temp;
                            break;
                        }

                
            }
            return array;
            // 2 8 9 <-3
        }
    }
}
