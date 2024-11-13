using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortVisualization2.Entity;

namespace SortVisualization2.Algorithms
{
    public class RadixSort
    {
        public static int GetMax(List<Element> elements, int n)
        {
            int max = elements[0].Value;
            for (int i = 1; i < n; i++) //start from 1 because we already set max to the first element
                if (elements[i].Value > max)
                    max = elements[i].Value;
            return max;
        }

        // useing counting sort to sort the elements based on significant places

        public static void CountingSort(List<Element> elements, int n, int place)
        {
            List<Element> output = new List<Element>(n); // output array 
            int i;
            int[] count = new int[10]; // count array for 0 to 9

            //initialize all count array elements to 0 in order to count the number of occurrences of each digit and store it in count array.
            for (i = 0; i < 10; i++) 
            { 
            count[i] = 0;
            }

            //store count of occurrences in count[] at the current significant digit place. get the current digit at the current significant place and increment the count of that digit.
            for (i = 0; i < n; i++)
            {
                count[(elements[i].Value / place) % 10]++;
            }

            //calculate the cumalative count by adding the previous count to the current count so that count[i] contains actual position of this digit in output array
            for (i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            //build the output array by placing the elements in their correct position in the output array
            //start from the end of the array so that the output array will be sorted in ascending order
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(elements[i].Value / place) % 10] - 1] = elements[i]; //get the current digit at the current significant place and get the actual position of that digit in the output array. 
                count[(elements[i].Value / place) % 10]--; //decrement the count of that digit in the count array so that the next occurrence of that digit will be placed at the next position in the output array.
            }

            //copy the output array to elements array(original array)
            for (i = 0; i < n; i++)
                elements[i] = output[i];

        }

        public void RadixSortAlgorithm(List<Element> elements, int n)
        {
            //get max element
            int max = GetMax(elements, n);

            //apply counting sort to sort elements based on place value.
            for (int place = 1; max / place > 0; place *= 10)//get the current significant place value.
            {
                CountingSort(elements, n, place);//sort the elements based on place value.
            }
        }







    }
}
