using System;

namespace IfOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int nummerA = 1;
            int nummerB = 2;
            int nummerC = 1;


            if (nummerA == nummerB)
            {
                Console.WriteLine("nummerA is gelijk aan nummerB");
            }
            else
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerB");
            }

            if (nummerA == nummerC)
            {
                Console.WriteLine("nummerA is gelijk aan nummerC");
            }
            else
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerC");
            }

            if (nummerA + nummerC == nummerB)
            {
                Console.WriteLine("nummerA+ nummerC is gelijk aan nummerB");
            }
            else
            {
                Console.WriteLine("nummerA+ nummerC is niet gelijk aan nummerB");
            }

            if (nummerA != nummerB)
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerB");
            }
            else
            {
                Console.WriteLine("nummerA is gelijk aan nummerB");
            }

        }
    }
}
