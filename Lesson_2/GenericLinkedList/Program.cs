using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Sandip", "Vikas", "Pratik", "Nikunj", "Vishal" };
            LinkedList<string> list = new LinkedList<string>(words);

            Console.Write("Enter product to find (type <end> toquit): ");
            string searchText = Console.ReadLine();

            while (searchText != "<end>")
            {
                if (list.Contains(searchText))
                {
                    Console.WriteLine("The search text was found\n");
                }
                else
                {
                    Console.WriteLine("The search text was NOT found\n");
                }

                Console.Write("Enter product to find (type <end> to quit): ");
                searchText = Console.ReadLine();


            }

        }
    }
}
