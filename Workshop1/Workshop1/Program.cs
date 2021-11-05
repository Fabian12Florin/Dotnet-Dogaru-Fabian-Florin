using System;

namespace Workshop1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            int x = 2;
            float a = 2.3f;
            double b = 3.1;
            string line=Console.ReadLine();
            Console.WriteLine(line);
            Console.Write(a);
            Console.WriteLine();
            Console.WriteLine(a); */

            /*char a = 'a';
            string ex = "asda@#4";
            Console.WriteLine(ex); */
            /*
            string s1 = "Test";
            string s2 = "Maine";
            s1 += "a";
            Console.WriteLine(s1);
            Console.WriteLine(s1 + " " + s2);

            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());

            string s3 = "     sadasd";
            Console.WriteLine(s3);
            Console.WriteLine(s3.Trim());

            int[] a = new int[10];
            int[] b = new int[] { 0, 1, 2, 3 };

            for(int i=0;i <b.Length;i++)
            {
                Console.WriteLine(b[i]);
            }

            int j = 0;
            while(j< a.Length)
            {
                a[j] = j;
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            do
            {
                Console.WriteLine("Test");
            } while (2 > 10);

            foreach(int i in a)
            {
                Console.WriteLine($"Elementul curent: {i}");
            }

            var x = 2;
            */

            // Console.WriteLine(test.Split());

            string test = "Ana are mere";
            var x = test.Split();

            foreach(var y in x)
            {
                Console.WriteLine(y);
            }

            Console.WriteLine(String.Join("$", x));

            bool variabila = true;
            if(!variabila && 1>0)
            {
                Console.WriteLine("Adevarat");
            }



        }
    }
}
