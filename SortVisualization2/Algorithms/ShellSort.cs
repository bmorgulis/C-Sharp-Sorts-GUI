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


//namespace C_Sharp_Homework1.HW4;

//public class resursiveShellSortRedone
//{
//    public class Node<T>
//    {
//        public T value;
//        public Node<T> next;

//        public Node(T value)
//        {
//            this.value = value;
//            this.next = null;
//        }
//    }


//    public class LinkedList<T> where T : IComparable<T>
//    {
//        public Node<T> head { get; private set; }

//        public void add(T value)
//        {
//            Node<T> newNode = new Node<T>(value);
//            if (head == null)
//            {
//                head = newNode;
//            }
//            else
//            {
//                Node<T> current = head;
//                while (current.next != null)
//                {
//                    current = current.next;
//                }

//                current.next = newNode;
//            }
//        }

//        public void shellSort()
//        {
//            int size = getSize();
//            int gap = size / 2;
//            shellSortHelperRecursive(gap);
//        }

//        public void shellSortHelperRecursive(int gap)
//        {
//            int size = getSize();
//            if (gap > 1)//bigger than one so that we only do a insertion sort when the gap is equal to one
//            {
//                for (int i = 0; i < gap; i++) //if gap is over 1 so do shell sort
//                {
//                    shellSortOnce(i, gap);
//                }
//                shellSortHelperRecursive(gap / 2); //recursively call shell sort on half of prior gap
//            }
//            else if (gap == 1)
//            {
//                insertionSort(); //once the gap is lowered to a space of 1 so do a regular insertion sort
//            }
//        }

//        public void shellSortOnce(int first, int gap)
//        {
//            for (int i = first + gap; i < getSize(); i += gap) // starts at the gap and compares and if needed swaps nodes gap size apart. goes until size of LL.
//            {
//                Node<T> current = getNodeValue(i); //current is the node at i
//                Node<T> start = getNodeValue(i - gap); //start is the node at i - gap which is the gap size apart

//                if (start != null && current.value.CompareTo(start.value) < 0) // if current is less than start then swap 
//                {
//                    T temp = current.value;
//                    current.value = start.value;
//                    start.value = temp;
//                }
//            }
//        }
//        public void insertionSort() //used algorithm straight from online
//        {
//            if (head == null || head.next == null)
//            {
//                return;
//            }
//            Node<T> sorted = null; //the head of the sorted portion of the linked list. initially null. later will be the head of the sorted linked list
//            Node<T> current = head;

//            while (current != null)
//            {
//                Node<T> next = current.next; //store next node
//                if (sorted == null || current.value.CompareTo(sorted.value) < 0)
//                {
//                    //insert at the start
//                    current.next = sorted;
//                    head = current;
//                    sorted = current;
//                }
//                else
//                {
//                    //insert current in correct position in sorted list
//                    Node<T> search = sorted;
//                    while (search.next != null && current.value.CompareTo(search.next.value) > 0)
//                    {
//                        search = search.next;
//                    }
//                    current.next = search.next;
//                    search.next = current;
//                }
//                current = next;
//            }

//        }
//        public Node<T> getNodeValue(int index)
//        {
//            Node<T> current = head;
//            for (int i = 0; i < index; i++)
//            {
//                current = current.next; //keep iterating until we reach the index that we want
//            }
//            return current;
//        }




//        public void printList()
//        {
//            Node<T> current = head;
//            while (current != null)
//            {
//                Console.WriteLine(current.value);
//                current = current.next;
//            }
//        }



//        public int getSize()
//        {
//            int length = 0;
//            Node<T> current = head;
//            while (current != null)
//            {
//                length++;
//                current = current.next;
//            }

//            return length;
//        }
//    }
//    public void main()
//    {
//        LinkedList<int> linkedList = new LinkedList<int>();
//        linkedList.add(46);
//        linkedList.add(57);
//        linkedList.add(312);
//        linkedList.add(7);
//        linkedList.add(23);
//        linkedList.add(3);
//        linkedList.add(1);
//        Console.WriteLine("Before sorting");
//        linkedList.printList();
//        linkedList.shellSort();
//        Console.WriteLine("After sorting");
//        linkedList.printList();

//    }


//}

