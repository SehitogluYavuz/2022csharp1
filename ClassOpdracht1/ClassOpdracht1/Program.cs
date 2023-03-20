using System;

namespace ClassOpdracht1
{
    internal class ClassStructureExercise
    {
        private readonly string accountName;

        // Constructor met parameter accountName
        internal ClassStructureExercise(string accountName)
        {
            this.accountName = accountName;
        }

        // Methode om een begroeting te tonen in de console
        internal void ShowGreetingInConsole()
        {
            Console.WriteLine("Hello, " + accountName + "!");
        }

        // Methode om de getallen 1 t/m 10 te tonen in de console
        internal void Show1To10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }

        // Methode om de afstand tussen twee punten te berekenen met behulp van de stelling van Pythagoras
        internal double DistBetweenPoints(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy);

            double length = Math.Sqrt(lengthSquared);
            return length;
        }

        // Methode om een getal te vermenigvuldigen met zichzelf
        internal int MultiplyToPower2(int value)
        {
            return value * value;
        }

        static void Main(string[] args)
        {
            // Maak een nieuwe instantie van ClassStructureExercise aan met accountName "John"
            ClassStructureExercise exercise = new ClassStructureExercise("John");

            // Roep de ShowGreetingInConsole-methode aan op de instantie van ClassStructureExercise
            exercise.ShowGreetingInConsole();

            // Roep de Show1To10-methode aan op de instantie van ClassStructureExercise
            exercise.Show1To10();

            // Roep de DistBetweenPoints-methode aan op de instantie van ClassStructureExercise
            double distance = exercise.DistBetweenPoints(0, 0, 3, 4);
            Console.WriteLine("Distance between points: " + distance);

            // Roep de MultiplyToPower2-methode aan op de instantie van ClassStructureExercise
            int result = exercise.MultiplyToPower2(5);
            Console.WriteLine("Result of multiplying 5 to power 2: " + result);
        }
    }
}
