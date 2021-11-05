using System;
using System.Linq;
using System.Collections.Generic;

namespace Introductiv //a namespace - used for organization
{
    class Program //a class- has member (such as a method)
    {
        static void Main(string[] args)  //a method (contain a block of code)
        {
            /* System.Console.WriteLine();  -this is the fully qualified name but because we use using System we no longer need to include it 
             there are others namespaces like List
             namespace -> classes -> method -> statements
             Console.WriteLine("Hello World!");  //a statement 
             WriteLine is a method (all methods contains () )  and Console is a class
             object test = new object();
             Program myProgram = new Program();
             myProgram.Print();

             Console.WriteLine(args[0]); //error we need to write something after this or use -- in terminal and then the comment */


            /*Dynamic Aplication
            Console.ReadLine(); // this is how we read something
            string name = Console.ReadLine(); //and this is how we assign something we read to an variable
            Console.WriteLine($"Hello {name}!");      this two make the same thing
            Console.WriteLine("Hello " + name + "!"); this is how we concatenate two strings */


            /*
            //Variable - they store values
            int x =  5;  //x is identifier
            int X = 50; //x and X are different
            var y = "Pizza"; //this is not dynamic
            Console.WriteLine(x);
            Console.WriteLine(y + " is good"); //so now we evaluate an expression

            int z; //declaration
            z = 10; //initialization

            //these below are simple types
            int a = -5;
            uint b = 5;
            char c = 'C';
            float d = 5.5F;
            double e = 4.2;
            decimal f = 5.5M; //use for exact precision
            bool g = true;
            string h = "Hello"; */


            /* //Array
            int[] a = { -5, 3, 4 };
            int[] b = a; //now b and a are pointing on the same array
            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]);
            b[0] = 10; //a[0] will also be 10
            b[1] = 2;  //a[1] will also be 2
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]); //a[2] is unchanged
            Console.WriteLine(b[0]);
            Console.WriteLine(b[1]);

            Test(a);
            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]); */


            /* //Built-in types
            Int32 x = 5; //refference in c# but it also work the one below
            int x1 = 5; //
            String y = "Fabi";
            string y1 = "Florin"; //uppercase and lowercase it does not mean anything in c#
            */


            /*
            //int = 32bits
            //uint only positive number
            int.MaxValue = show the max value stored on int
            int x = (int)5.999999; //x is 5...this is how we convert a double in int
            double y = 5; //this work
            // float z = 5.5   error because float has 32 bits and double has 64 bits
            //float z = (float)5.5; or float z = 5.5f;
            double z1 = 5.5f; //we can store a float in a double

            double a = double.NaN;
            Console.WriteLine(double.IsNaN(a));

            double a1 = double.PositiveInfinity;
            Console.WriteLine(double.IsInfinity(a1));

            double a2 = Math.Pow(9999, 99999999);
            Console.WriteLine(double.IsPositiveInfinity(a2));

            decimal. and all his functions */


            /* //Math class
            double x = 50.5;
            double y = 300;
            Console.WriteLine(Math.Round(x));  //if is x.5 then will round to nearest even number
            Console.WriteLine(Math.Round(x,0,MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Floor(x));
            Console.WriteLine(Math.Ceiling(x));
            Console.WriteLine(Math.Truncate(x));
            Console.WriteLine(Math.Min(y,x));
            Console.WriteLine(Math.Abs(x));
            Console.WriteLine(Math.Sign(x));
            */

            /*
            //Character data type
            char letter = 'a';
            //char letter2 = "a"; //error because it can not convert string to char
            int number = '\t'; //tab
            Console.WriteLine("Hello\tKitty");

            char letter2 = (char)97;
            char letter3 = (char)936;  //unicode table
            Console.WriteLine(letter3);
            Console.WriteLine(letter2);

            string name = "Fabi";
            string name2 = name;
            name += "Florin"; // += concatenate 2 string
            Console.WriteLine(name);
            Console.WriteLine(name2);


            string name3 = "Fabi";
            char[] characters = {'h','e','l','l','o'};
            string greeting = new string(characters);
            Console.WriteLine(greeting);

            string message = $"Hello my name is {name3}, and i like to say {greeting}";
            Console.WriteLine(message); */


            /*
            string name = "Fababi";
            Console.WriteLine(name.Length);
            //name == "Fabi"; return true
            Console.WriteLine(name.CompareTo("Fabi")); //0 if is equal   negative if name is < than the string we compare and positive in the other case
            int position = name.IndexOf("ab");
            Console.WriteLine(position);
            Console.WriteLine(name.IndexOf("ab",2));
            Console.WriteLine(name.Remove(1,2));
            Console.WriteLine(name.ToLower());
            
            string name2 = "Hello my name is Fabi";
            Console.WriteLine(name2.Split(' '));
            string[] words = name.Split(' ');
            Console.WriteLine(words[1]);
            */

            /*
            string name = "\a hello my name \\is \"Fabi\"";  //  \is an escape sequences
            char letter = '\'';
            Console.WriteLine(name);

            string name2 = @"hello my name \tis ""Fabi""";
            Console.WriteLine(name2);
            */

            /*
            Person person = new Person();
            person.FirstName = "Fabi";
            person.LastName = "Florin";

            Console.WriteLine(person.GetFullName());
            Console.WriteLine(person.FullName);

            Console.WriteLine("What do you think the name is?");
            string fullNameGuess = Console.ReadLine();

            Console.WriteLine("Second guess?");
            string fullNameGuess2 = Console.ReadLine();

            if (person.FullName == fullNameGuess)
            {
                Console.WriteLine("You got the name! You win");
            }
            else if(person.FullName == fullNameGuess2)
            {
                Console.WriteLine("You got it! 1/2 points");
            }
            else
            {
                Console.WriteLine("You trash");
            }
            */

            /*
            Console.WriteLine("Your age?");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Whats the pass?");
            string password = Console.ReadLine();

            if(age > 12 && password == "password123")
            {
                Console.WriteLine("You're at least a teenager and got the password");
            }
            */

            /*
            string name = "Fabi";
            switch(name)
            {
                case "Fabi":
                    Console.WriteLine("Legit!");
                    break;
                case "Clara":
                    Console.WriteLine("Be careful bro!");
                    break;
                case "Steve":
                case "Alex": //it is like an or ||
                    Console.WriteLine("Nether");
                    break;
                default:
                    Console.WriteLine("You can go bankrupt!");
                    break;
            }
            */

            /*
            //expression ? true : false
            //if(expression)
            bool correct = true;
            int pointsEarned = correct ? 10 : 0;
            Console.WriteLine(pointsEarned);

            string name = "Fabi";
            if (name == "Claire")
            {
                Console.WriteLine("No No"); 
                Console.WriteLine();
            }
            */

            /*
            int i = 0;  //initialization
            while(i<10)  //condition
            {
                Console.WriteLine(i);
                i++;  //update
            }

            int j = 0;
            do 
            {
                Console.WriteLine(j);
                j++;
            }
            while (j<10);
            
            for(int z = 0; z < 10; z++)
            {
                Console.WriteLine(z);
            }
            */

            /*
            int i;
            for(i = 9; i >= 0 ; i--)
            {   
                if(i == 4)
                {
                    continue;
                }
                for(int k = i; k >= 0; k--)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
            */

            /*
            int[] grades = new int[10];
            grades[0] = 900;
            grades[0] = 901;
            Console.WriteLine(grades[0]);
            */

            /*
            int[] grades = { 900, 20, 30, 41 };
            Console.WriteLine( grades[3]);
            */

            /*
            int size = Convert.ToInt32(Console.In.ReadLine());
            int[] grades = new int[size];

            for(int i = 0; i < grades.Length; i++)
            {
                grades[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            for(int i = 0; i < grades.Length; i++)
            {
                Console.Write(grades[i] + " ");
            }
            */

            /*
            int[] grades = { 30, 430, 23, 10 };
            Console.WriteLine(Array.IndexOf(grades, 23));
            Console.WriteLine(Array.IndexOf(grades, 24000));
            */

            /*
            int[] grades = { 30, 430, 23, 10 };
            Array.Sort(grades);  //sort my array
            Array.Reverse(grades);

            int[] grades1 = { 30, 430, 23, 10 };
            int[] grades2 = { 30, 430, 23, 10 };
            if(Enumerable.SequenceEqual(grades1,grades2))
            {
                Console.WriteLine("Equal");
            }
            */


            /*int[,] grades = new int[3, 4];
            grades[0,2] = 5;
            Console.WriteLine(grades[0,2]);
            */

            /*int[,] grades =
            {
                { 5, 4, 1, 3 },
                { 3, 2, 2, 2 },
                { 2, 4, 4, 2 },
                { 1, 1, 6, 3 }
            };

            Console.WriteLine(grades[0,2]);
            */


            /*
            int[][] grades =
            {
                new int[] {5, 4, 3, 1},
                new int[] {5, 4, 3, 1, 3, 5, 7, 3},
                new int[] {5, 4, 3, 1, 3, 2},
            };

            Console.WriteLine(grades[1][6]);
            Console.WriteLine(grades.Length);
            Console.WriteLine(grades[1].Length);
            
            for(int i = 0; i < grades.Length; i++)
            {
                for(int k = 0; k < grades[i].Length; k++)
                {
                    Console.Write(grades[i][k] + " ");
                }
                Console.WriteLine();
            }
            */


            /*List<int> grades = new List<int>();
            grades.Add(5);
            grades.Add(10);*/

            /*
            List<int> grades = new List<int>() { 5, 10 };
            grades.Add(30);
            grades.Insert(2, 15);
            Console.WriteLine(grades[0]);
            */

            /*List<int> grades = new List<int>() { 5, 10, 26, 34, 2, 23, 200 };
            if(grades.IndexOf(23) == 5)
            {
                Console.WriteLine("True");
            }
            */

            /*
            List<int> grades1 = new List<int>() { 5, 10, 26, 34, 2, 23, 200 };
            List<int> grades2 = new List<int>() { 5, 10, 26, 34, 2, 23, 200 };

            if(grades1.SequenceEqual(grades2))
            {
                Console.WriteLine("Equal");
            }
            */

            /*List<int> grades = new List<int>() { 5, 10, 26, 34, 2, 23, 200 };
            for(int i = 0; i < grades.Count; i++)
            {
                grades[i] *= 2;
                Console.WriteLine(grades[i]);
            }
            */

            /*List<int> grades = new List<int>() { 5, 10, 26, 34, 2, 23, 200 };
            foreach (int grade in grades)  //use for read elements not update elements
            {
                Console.WriteLine(grade);
            }
            */

            /*
            List<int> grades = new List<int>() { 5, 10, 26, 34, 2, 23, 200 };
            foreach (int grade in grades.ToArray()) 
            {
                Console.WriteLine(grade);
            }
            */

            Console.WriteLine("C# is fun");



        }

        void Print() //another method from class Program
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Best friend!");
        }

        static void Test(int[] a)
        {
            a[0] = 100;
        }
    }
}
