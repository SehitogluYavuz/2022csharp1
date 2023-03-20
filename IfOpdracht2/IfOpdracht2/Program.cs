using System;

namespace IfOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Enemy enemy = new Enemy() { hp = 10 };

            enemy.hp -= 5;
            Console.WriteLine("you hit enemy for 5 damage");

            if (enemy.hp > 0)
            {
                Console.WriteLine("enemy is still alive!");
            }

            enemy.hp -= 20;
            Console.WriteLine("you hit enemy for 20 damage");

            if (enemy.hp <= 0)
            {
                Console.WriteLine("enemy was defeated");
            }
        }
    }

    class Enemy
    {
        public int hp;
    }
}
