using System;

namespace ClassOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Maak een instantie van de ShopGreeter-klasse aan
            ShopGreeter greeter = new ShopGreeter();

            // Roep de greetCustomer-functie aan en geef een naamargument mee
            greeter.greetCustomer("John");
        }
    }

    internal class ShopGreeter
    {
        internal void greetCustomer(string name)
        {
            Console.WriteLine("Welcome to our shop, " + name + "!");
        }
    }
}
