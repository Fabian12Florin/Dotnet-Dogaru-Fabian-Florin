using System;
using System.Collections.Generic;

namespace Workshop2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List<int> myList = new List<int> { };

             myList.Add(5);
             myList.Add(6);
             myList.Add(7);
             myList.Add(8);
             myList.Add(9);

             //Console.WriteLine(myList.Exists(p => p==4));
             //Console.WriteLine(myList.Find(p => p==5));
             //Console.WriteLine(myList.IndexOf(5));

             HashSet<int> mySet = new() { };

             mySet.Add(1);
             mySet.Add(1);

             Dictionary<int, string> myDictionary = new Dictionary<int, string> { };

             myDictionary.Add(5, "Pisica");
             myDictionary.Add(25, "Catel");

             Console.WriteLine(myDictionary.GetValueOrDefault(5));
             string aux = "";
             Console.WriteLine(myDictionary.TryGetValue(5, out aux));


             Queue<int> myQueue = new Queue<int> { };

             myQueue.Enqueue(5);
             myQueue.Enqueue(6);
             myQueue.Enqueue(7);

             //int a = myQueue.Dequeue();
             //Console.WriteLine(a);

             int a = myQueue.Peek();
             Console.WriteLine(a);

             int b = myQueue.Peek();
             Console.WriteLine(b);

             //Console.WriteLine(myQueue.Peek());
             */

            /*
            Stack<int> myStack = new Stack<int> { };
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);

            Console.WriteLine(myStack.Pop());
            */

            Person persoana = new Person("Fabi", "Dogaru", 1234);
            persoana.afisare();

            Console.WriteLine(persoana.Sum(4,11));
            Console.WriteLine(persoana.Sum(2,3,5));
        }
    }
}
