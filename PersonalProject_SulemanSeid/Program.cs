using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject_SulemanSeid
{
    public class Program
    {
        // Declare the global linked list
        static LinkedList<string> StoreDirectory;
        static void Main(string[] args)
        {
            Preload();

            Console.WriteLine("Contains");
            Console.WriteLine(StoreDirectory.Contains("Aqua Adventures").ToString()); // True
            Console.WriteLine(StoreDirectory.Contains("Zara").ToString()); // False
            Console.WriteLine("Print");
            PrintStoreNames(); // print the store names
            // Create a new node with the store name
            var newNode = new LinkedListNode<string>("New Store Name");
            StoreDirectory.AddLast(newNode);// print the store names
        }
        // Method to preload the store names into the linked list
        static void Preload()
        {
            StoreDirectory = new LinkedList<string>(); // create a new linked list
            StoreDirectory.AddLast("Aqua Adventures"); // add store names
            StoreDirectory.AddLast("Barnes & Noble");
            StoreDirectory.AddLast("Dairy Queen");
            StoreDirectory.AddLast("Express");
            StoreDirectory.AddLast("Foot Locker");
            StoreDirectory.AddLast("Gap");
            StoreDirectory.AddLast("H&M");
            StoreDirectory.AddLast("IHOP");
            StoreDirectory.AddLast("JCPenney");

            // Create a linked list of strings
            LinkedList_Singly<string> list = new LinkedList_Singly<string>();
            // Add some elements to the list
            list.Add("Hello");
            list.Add("World");
            list.Add("!");

            // Display the list
            list.Display();

            // Remove the first element
            //list.Remove("Hello");

            // Display the list again
            list.Display();

            // Insert an element at index 1
            list.InsertAtIndex(1, "C#");

            // Display the list again
            list.Display();

            // Clear the list
            //list.Clear();

            // Display the list again
            //list.Display();

        }
        // Method to print store names
        static void PrintStoreNames()
        {
            foreach (var storeName in StoreDirectory)
            {
                Console.WriteLine(storeName);
            }

        }
    }
}
