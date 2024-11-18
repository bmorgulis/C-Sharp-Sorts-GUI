using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SortVisualization2.Entity;
using SortVisualization2.Options;

namespace SortVisualization2.Algorithms
{
    public class InsertionSort
    {
        public void InsertionSortAlgorithm(List<Element> elements, Graphics graphic)
        {
            int size = elements.Count;
            for (int i = 1; i < size; i++) //start from 1 because we assume the first element is already sorted
            {
                Element elementToInsert = elements[i]; //the element we are going to insert into the sorted part of the array
                int j = i - 1; //the last element of the sorted part of the array

                // will compare the elementToInsert with all the already sorted elements to the left(j) until it finds a smaller one and then insert elementToInsert there
                while (j >= 0 && elements[j].Value > elementToInsert.Value)
                {
                    elements[j + 1] = elements[j]; //shift the element to the right
                    j = j - 1;
                }
                elements[j + 1] = elementToInsert; //insert the elementToInsert into the correct position
            }
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using SortVisualization2.Options;

//namespace SortVisualization2.Algorithms
//{
//    public class InsertionSort
//    {
//        public static void InsertionSortAlgorithm(List<int> elements, Graphics graphic)
//        {
//            int size = elements.Count;
//            for (int i = 1; i < size; i++) //start from 1 because we assume the first element is already sorted
//            {
//                int elementToInsert = elements[i]; //the element we are going to insert into the sorted part of the array
//                int j = i - 1; //the last element of the sorted part of the array

//                // will compare the elementToInsert with all the already sorted elements to the left(j) until it finds a smaller one and then insert elementToInsert there
//                while (j >= 0 && elements[j] > elementToInsert)
//                {
//                    elements[j + 1] = elements[j]; //shift the element to the right
//                    j = j - 1;

//                    // Draw the current state of the array
//                    DrawElements(elements, graphic);
//                    Thread.Sleep(50); // Add a small delay to visualize the sorting process
//                }
//                elements[j + 1] = elementToInsert; //insert the elementToInsert into the correct position

//                // Draw the current state of the array
//                DrawElements(elements, graphic);
//                Thread.Sleep(50); // Add a small delay to visualize the sorting process
//            }
//        }

//        private static void DrawElements(List<int> elements, Graphics graphic)
//        {
//            graphic.Clear(Color.White); // Clear the previous drawing
//            for (int i = 0; i < elements.Count; i++)
//            {
//                // Draw each element as a rectangle
//                graphic.FillRectangle(Brushes.Blue, i * 10, 0, 10, elements[i]);
//            }
//        }
//    }
//}
