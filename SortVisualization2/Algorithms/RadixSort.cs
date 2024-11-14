using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortVisualization2.Entity;
using SortVisualization2.Options;

namespace SortVisualization2.Algorithms
{
    public class RadixSort
    {
          public static int GetMax(List<Element> elements)
        {
            if (elements == null || elements.Count == 0)
                throw new ArgumentException("Array cannot be null or empty");

            int max = elements[0].Value;
            for (int i = 1; i < elements.Count; i++) //start from 1 because we already set max to the first element
                if (elements[i].Value > max)
                    max = elements[i].Value;
            return max;
        }

        // using counting sort to sort the elements based on each places value(first ones, then tens, then...)

        public static void CountingSort(List<Element> elements, int place, Graphics graphic)
        {
            int size = elements.Count;
            List<Element> output = new List<Element>(new Element[size]);// output array. The sorted elements will be placed here.

            //List<Element> output = new List<Element>();  // List to hold sorted elements
            //for (int i = 0; i < size; i++)
            //{
            //    output.Add(new Element(new Point(), new Point(), 0)); // Initialize each element in the output list
            //}



            int[] count = new int[10]; //to count how often each digit appears at the current place value

          
            InitializeCountArray(count);

            GetCountArray(count, elements, place, size);//get the count of each digit at the current place value

            CumulativeCountArray(count);//calculate the cumulative count so that count[i] contains actual position of this digit in output array

            BuildOutputArray(elements, output, count, place, graphic);//build the output array

            UpdateTheOutputArray(elements, output, graphic);//copy the output array to the elements array(original array)
        }


        //initialize the elements in the count array to 0 to prep for counting the number of occurrences of each digit.
        public static void InitializeCountArray(int[] count)
        {
            for (int i = 0; i < 10; i++)
            {
                count[i] = 0;
            }
        }

        //get the count of occurances of each digit at the current significant place value.
        public static void GetCountArray(int[] count, List<Element> elements, int place, int size)
        {
            for (int i = 0; i < size; i++)
            {
                count[(elements[i].Value / place) % 10]++;
            }
        }

        //Cumulative count array. Calculate the cumalative count by adding the previous count to the current count so that count[i] contains actual position of this digit in output array
        public static void CumulativeCountArray(int[] count)
        {
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }
        }

        //build the output array by placing the elements in their correct position in the output array
        //start from the end of the array so that the output array will be sorted in ascending order
        public static void BuildOutputArray(List<Element> elements, List<Element> output, int[] count, int place, Graphics graphic)
        {
            int size = elements.Count;
            for (int i = size - 1; i >= 0; i--)
            {
                int index = (elements[i].Value / place) % 10;
                output[count[(elements[i].Value / place) % 10] - 1] = elements[i]; //get the current digit at the current significant place and get the actual position of that digit in the output array. 
                count[(elements[i].Value / place) % 10]--; //decrement the count of that digit in the count array so that the next occurrence of that digit will be placed at the next position in the output array.



                // Erase the element from the previous position
                elements[i].Eraser(graphic);
                //// Draw the element in its new position
                elements[count[index]].Draw(graphic);//draw the current element in its new position
                                                     //elements[i].Draw(graphic);
            }
        }

        //copy and update the output array to elements array(original array)
        public static void UpdateTheOutputArray(List<Element> elements, List<Element> output, Graphics graphic)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i] = output[i];

                //Draw the elements
                elements[i].Eraser(graphic);
                elements[i].Draw(graphic);
                Thread.Sleep(ArrayOptions.Delayed);
            }
        }




    public void RadixSortAlgorithm(List<Element> elements, Graphics graphic)
        {
            //get max element
            int max = GetMax(elements);


            //apply counting sort to sort elements based on place value.
            for (int place = 1; max / place > 0; place *= 10)//get the current significant place value.
            {
                CountingSort(elements, place, graphic);//sort the elements based on place value.
            }

            ElementHelper.CompletedList(elements, graphic); // Show final sorted list
        }
    }
}
