using System;

namespace LineComparsion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparsion Problem Statement");
            //UC1
            Operation operation1 = new Operation(2, 1, 4,3);
            double line1 = operation1.CalculateLength();
            Operation operation2 = new Operation(2, 1, 5, 3);
            double line2 = operation2.CalculateLength();
            //UC2
            if (line1.Equals(line2))
                   Console.WriteLine("Line1 and Line2 Are Equal");
               else
                   Console.WriteLine("Line1 and Line2 AreNot Equal");
            //UC3
            if (line1.CompareTo(line2) == 0)
                Console.WriteLine("Both Lines are Equal");
            if (line1.CompareTo(line2) > 0)
                Console.WriteLine("Line1 is Greater than Line2");
            if (line1.CompareTo(line2) < 0)
                Console.WriteLine("Line2 is Greater than Line1");

        }
    }
}
