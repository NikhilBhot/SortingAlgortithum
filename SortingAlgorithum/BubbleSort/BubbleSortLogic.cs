using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSortLogic
    {
        public static void bubbleSortLogic(int[] arr) 
        { 
            int n=arr.Length;
            for(int i=0;i<n-1; i++) 
            {
               int flag = 0;
                for(int j=0;j<n-1-i;j++) //j<n-1-i used for last number is sorted so we decrement that
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp; 
                        flag = 1;  //if swapping is done then we set to 1
                    }
                }
                if (flag == 0)  //
                    break;
            }
        }
    }
}
