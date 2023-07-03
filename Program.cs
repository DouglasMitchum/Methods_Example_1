/*
Author: Doug Mitchum
Date: 7/3/2023
Description: C# console application for testing methods
*/

namespace Methods_Example_1
{
    class Program
    {
        /* A method is a block of code which only runs when it is called.
         * You can pass data into a method (parameters).
         * reuse the code (define the code once, and use it many times).
         */

        /* Example (1)
         * A method is defined with the name and followed by parentheses
         * MyMethod: name is the name of the method (function)
         * static: means that the method belong to the program class
         * void means that the method does not have a return value
         */

        static void MyMethod()
        {
            Console.WriteLine("I just got executed! ");
        }

        // Example (2)
         

        static void MyMethod2(string name, int age) 
        {
            Console.WriteLine(name + " is " + age.ToString() + " years ");
        }

        // Example (3)

        static int MyMethod3(int x, int y) 
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            MyMethod();
            Console.WriteLine(" ");
            MyMethod2("Weimar", 30);
            Console.WriteLine(" ");

            int z = MyMethod3(5, 5);
            Console.WriteLine("MyMethod3 outcome is: " + z);

            //Example (4) (using arrays)

            int[] numbers = { 2, 2, 3, 5, 9 };
            Console.WriteLine("Enter an integer number");
            int input = int.Parse(Console.ReadLine());

            foreach (int number in numbers)
            {
                Console.WriteLine("");
                int i = MyMethod3(number, input);
                Console.WriteLine(i);
            }
        }
    }
}