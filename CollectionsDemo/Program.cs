using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collections!");
            ListDemo();
            StackDemo();
            QueueDemo();
            HashSetDemo();
            DictionaryDemo();
        }

        public static void ListDemo()
        {
            Console.WriteLine("\nLists >>>>>>>>>>");
            ///<summary>
            ///Creating lists of string
            ///</summary>
           
            List<string> name = new List<string>(); 
            name.Add("Sunny");
            name.Add("Bunny");
            name.Add("Karan");
            name.Add("Ajay");

            ///<summary>
            ///Creating lists of prime numbers
            ///</summary>
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(7);

            ///<summary>
            ///Iterating through the lists
            ///</summary>

            Console.WriteLine("\nNames Before..........");
            foreach (var names in name)
            {
                Console.WriteLine(names);
            }

            Console.WriteLine("\nPrime Numbers Before.........");
            foreach(var primes in primeNumbers)
            {
                Console.WriteLine(primes);
            }

            Console.WriteLine("\nAfter removing a name........");
            name.Remove("Karan");
            foreach (var names in name)
            {
                Console.WriteLine(names);
            }

            Console.WriteLine("\nAfter inserting a prime number in between.........");
            primeNumbers.Insert(2, 5);
            foreach (var primes in primeNumbers)
            {
                Console.WriteLine(primes);
            }
        }
        private static void StackDemo()
        {
            Console.WriteLine("\nStack>>>>>>>>>>>");

            Stack<int> number = new Stack<int>();
            number.Push(1);
            number.Push(2);
            number.Push(3);
            number.Push(4);
            number.Push(8);

            Console.WriteLine("\nNumbers Before............");
            foreach(var numbers in number)
            {
                Console.WriteLine(numbers);
            }

            int pop = number.Pop();
            Console.WriteLine("\nNumbers after popping............");
            foreach (var numbers in number)
            {
                Console.WriteLine(numbers);
            }

            int peek = number.Peek();
            Console.WriteLine("\nNumber at the top of stack............");
            Console.WriteLine(number.Peek());


            Console.WriteLine("\nIs the number present...........");
            Console.WriteLine(number.Contains(21));
                
        }
        private static void QueueDemo()
        {
            Console.WriteLine("\nQueue>>>>>>>>>>>");

            Queue<int> number = new Queue<int>();
            number.Enqueue(1);
            number.Enqueue(2);
            number.Enqueue(3);
            number.Enqueue(4);
            number.Enqueue(8);

            Console.WriteLine("\nNumbers Before............");
            foreach (var numbers in number)
            {
                Console.WriteLine(numbers);
            }

            int dequeue = number.Dequeue();
            Console.WriteLine("\nNumbers after getting dequeued............");
            foreach (var numbers in number)
            {
                Console.WriteLine(numbers);
            }
        }
        private static void HashSetDemo()
        {
            Console.WriteLine("\nHashSet>>>>>>>>>>>>>");
            HashSet<string> names = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit"
            };

            Console.WriteLine("\nHashSet before...........");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            names.Add("Rajeev");
            //duplicates are not added into collection.   

            Console.WriteLine("\nHashset After............");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
        private static void DictionaryDemo()
        {
            Console.WriteLine("\nDictionary>>>>>>>>>>>");
            Dictionary<int, string> numberPlace = new Dictionary<int, string>
            {
                { 1, "Mumbai" },
                { 2, "Delhi" },
                { 3, "Chennai" }
            };

            Console.WriteLine("\nAdding number places before..............");
            foreach(var dictelements in numberPlace)
            {
                Console.WriteLine("Key: "+dictelements.Key+" Place: "+dictelements.Value);
            }
        }
    } 
}
