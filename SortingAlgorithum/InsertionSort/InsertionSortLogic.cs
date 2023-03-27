using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSortLogic
    {
        public static void insertionSortLogic(int[] arr) 
        {
            int n=arr.Length;
            for(int i=1;i<n;i++) //this for start with 1 beacause 0 th elemement we consider as soerted 
            {
                int temp = arr[i]; //store the value which we have to sort
                int j = i - 1;
                while(j >= 0 && arr[j]>temp) //this while loop going on upto we didint get correct postion 
                {
                    arr[j + 1] = arr[j];
                    j--;  //we shift the element for correct postioon
                }
                arr[j+1]=temp;
            }
        }
    }
}
