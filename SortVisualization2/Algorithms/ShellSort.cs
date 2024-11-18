using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SortVisualization2.Entity;

namespace SortVisualization2.Algorithms
{
    public class ShellSort
    {
       
        public void ShellSortAlgorithm(List<Element> elements, Graphics graphic)
        {
            int size = elements.Count;
            for (int gap = size / 2; gap > 0; gap = gap / 2) //reduce the gap by half each time. The last gap will be 1. 
            {
                for(int i = gap; i < size; i++) //start from the gap because the elements before the gap are already sorted
                {
                    Element temp = elements[i]; //the element we are going to insert into the sorted part of the array
                    int j;
                    for (j = i; j >= gap && elements[j - gap].Value > temp.Value; j = j - gap)
                    {
                        elements[j] = elements[j - gap];
                    }
                    elements[j] = temp;
                }
            }
        }
    }
}