using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOpdracht4
{
    internal class GameRenderer
    {
        private GameScreen currentScreen;

        // Constructor
        internal GameRenderer(GameScreen screen)
        {
            this.currentScreen = screen;
        }

        internal void SetScreen(GameScreen screen)
        {
            this.currentScreen = screen;
        }

        internal void Render()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string line in currentScreen.GetScreenLines())
            {
                Console.WriteLine(line);
            }
        }
    }
}
