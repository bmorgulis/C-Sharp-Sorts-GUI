using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortVisualization2.Entity;

namespace SortVisualization2.Algorithms
{
    public class HeapSort
    {
        public void Heapify(List<Element> elements, int size, int root, Graphics graphic)
        {
            int largest = root;
            int left = 2 * root + 1; //left child
            int right = 2 * root + 2;//right child

            //check if left bigger than parent
            if(left < size && elements[left].Value > elements[largest].Value)
            {
                largest = left; // store the largest
            }

            if (right < size && elements[right].Value > elements[largest].Value)
            {
                largest = right; // store the largest
            }

            //if the largest is not the root do a swap
            if (largest != root)
            {
                Element temp = elements[root];
                elements[root] = elements[largest];
                elements[largest] = temp;

                //continue moving down to check if any nodes are larger
                Heapify(elements, size, largest, graphic);



                //ElementHelper.DrawSwap(elements[largest], elements[root], graphic);
                //ElementHelper.ElementSwap(elements, largest, root);

                ////recursively heapify the affected sub-tree
                //Heapify(elements, size, largest, graphic);
            }
        }


        public void Sort(List<Element> elements, Graphics graphic)
        {
            int size = elements.Count;

            //make a max heap- for loop from last non leaf node to the root node that calls the heapify function
            //build heap
            for (int i = size / 2 - 1; i >= 0; i--)//will start from the last non leaf node = n/2-1 and check all possible children
            {
                Heapify(elements, size, i, graphic);
            }

            //extract largest node
            for (int i = size - 1; i >= 0; i--)
            {
                Element temp = elements[0];
                elements[0] = elements[i];
                elements[i] = temp;

                //ElementHelper.DrawSwap(elements[0], elements[i], graphic);

                //check the new smaller array
                Heapify(elements, i, 0, graphic);
            }
        }


    }
}
