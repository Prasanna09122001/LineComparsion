using System;
using System.Numerics;

namespace LineComparsion
{
    class Operation
    {
        int x1, x2, y1, y2;
        public Operation(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;

        }
        public double CalculateLength()
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of the Line" + length);
            return length;
        }
    }
}
