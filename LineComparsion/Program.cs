using System;

namespace LineComparsion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparsion Problem Statement");
            Operation operation = new Operation(2, 1, 4,3);
            operation.CalculateLength();

        }
    }
}
