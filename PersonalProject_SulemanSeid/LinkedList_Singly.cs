using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject_SulemanSeid
{
    public class LinkedList_Singly<T>
    {
        // Define a class for the linked list node 
        public class Node
        {
            public T Data { get; set; } // store name
            public Node Next { get; set; } // pointer to the next node

            // constructor that takes a data value
            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }
        private Node head; // pointer to the first node
        private int count; // number of nodes in the list

        // Public property to access the number of elements in the list
        public int Count => count;

        // Define a class for the linked list
        public LinkedList_Singly()
        {
            head = null;
            count = 0;
        }
        // method to add a node at the end of the list
        public void Add(T data)
        {
            Node newNode = new Node(data); // create a new node
            if (head == null) // if the list is empty
            {
                head = newNode; // set the head to the new node
            }
            else // if the list is not empty
            {
                Node current = head; // start from the head
                while (current.Next != null) // loop until the last node
                {
                    current = current.Next; // move to the next node
                }
                current.Next = newNode; // add the new node to the end
            }
            count++; // increment the count
        }
        // method to display the elements of the list
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        // Core Method: Remove elements by their values
        public void Remove(T data)
        {
            if (head == null)
            {
                return; // Empty list, nothing to remove
            }

            if (head.Data.Equals(data))
            {
                head = head.Next;
                count--;
                return;
            }

            Node current = head;
            while (current.Next != null && !current.Next.Data.Equals(data))
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
                count--;
            }
        }
        // Indexer override to access elements by index
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                Node current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                return current.Data;
            }
        }

        // Additional Methods for inserting elements

        public void InsertAtIndex(int index, T data)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }

            Node newNode = new Node(data);
            Node current = head;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;

            count++;
        }

        // Method to clear the linked list
        public void Clear()
        {
            head = null;
            count = 0;
        }
    }
}
