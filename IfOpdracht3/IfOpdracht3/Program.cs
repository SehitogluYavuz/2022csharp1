using System;

namespace IfOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan de AND operator (&&) gebruiken
            //een lekker ijsje, alleen welke smaken kiezen we?

            //maak van 2 false hieronder true
            bool chocola = true;
            bool vanilla = false;
            bool aardbei = true;

            if (chocola && vanilla)
            {
                Console.WriteLine("hier is je chocola vanilla ijsje");
            }
            else if (chocola && aardbei)
            {
                Console.WriteLine("hier is je chocola aardbei ijsje");
            }
            else if (vanilla && aardbei)
            {
                Console.WriteLine("hier is je vanilla aardbei ijsje");
            }
        }
    }
}
