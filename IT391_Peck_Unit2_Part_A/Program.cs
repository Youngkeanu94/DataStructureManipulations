using System;
using System.Collections.Generic;


namespace IT391_Peck_Unit2_Part_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("********Part A: Section 1 ********");
            Console.WriteLine();
            Console.WriteLine("Enter any word and hit enter to see the word reversed: ");
            string str = Console.ReadLine();
            Console.WriteLine(ReverseWord(str));
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("********Part A: Section 2 ********");
            Console.WriteLine();

            getShoppers();

            Console.ReadKey();
        }
        private static string ReverseWord(string str)
        {
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < str.Length; i++)
                stack.Push(str.Substring(i, 1));

            string reversed = string.Empty;

            for (int i = 0; i < str.Length; i++)
                reversed += stack.Pop();
            return reversed;
        }
        private static void getShoppers()
        {
            Queue<String> shoppers = new Queue<string>();
            shoppers.Enqueue("Jane");
            shoppers.Enqueue("Bob");
            shoppers.Enqueue("Liza");
            shoppers.Enqueue("Tom");
            shoppers.Enqueue("Mary");

            Console.WriteLine("The number of shoppers at the grocery store when the store opens is " + shoppers.Count);


            Console.WriteLine("The first shopper in line is " + shoppers.Peek());

            shoppers.Enqueue("Stephen");
            shoppers.Enqueue("Ellen");


            //shoppers.Dequeue();
            //shoppers.Dequeue();
            //shoppers.Dequeue();

            for (int i = 1; i < 4; i++)
            {
                shoppers.Dequeue();
            }

            System.Console.WriteLine("There are now " + shoppers.Count + " shoppers in the line.");
            System.Console.WriteLine(shoppers.Peek() + " is now at the head of the line.");
            Console.ReadLine();
        }
    }
}

