using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FinalHud
{
    internal class Program
    {
        private static int Health = 100;
        private static int Shield = 50;
        private static int Lives = 1;
        private static float ScoreMultiplier = 0f;

        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO CAVE ESCAPE");
            Console.WriteLine("----------------------");

            ShowHUD();

            Console.WriteLine("------------");
            Console.WriteLine("START GAME");
            Console.WriteLine("");

            Console.WriteLine("You Awaken in a dark cave, cold and damp. Torch in hand, you begin your perilous journey back to the surface.");

            Console.WriteLine("As you enter a new part of the cave, you come across a goblin with an old rusty sword");
            Console.WriteLine("");
            Console.WriteLine("It Attacks You!");

            TakeDamage(30);

            Console.WriteLine("------------");
            Console.WriteLine("");
            Console.WriteLine("You do a counter-attack and kill the goblin!");
            Console.WriteLine("");
            Console.WriteLine("------------");

            AddScore(15, 0.5f);

            Console.WriteLine("------------");
            Console.WriteLine("");
            Console.WriteLine("You come across an underwater waterfall inside the cave. You see a Giant bat emerge from behind the waterfall!");
            Console.WriteLine("It spits mutated acid at you!");
            Console.WriteLine("");
            Console.WriteLine("------------");

            TakeDamage(50, 20);

            Console.WriteLine("------------");
            Console.WriteLine("");
            Console.WriteLine("The bat flies away before you can attack it!");
            Console.WriteLine("");
            Console.WriteLine("After a long journey to the surface, you begin to see the light from the sun on the cold cave rocks.");
            Console.WriteLine("Just before you reach the exit, a huge troll blocks your path. It roars and swings its massive club right on top of you, ending your journey!");
            Console.WriteLine("");
            Console.WriteLine("------------");

            TakeDamage(20, 30, 1);

            Console.WriteLine("------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.ResetColor();

            Console.ReadKey(true);
        }

        private static void ShowHUD()
        {
            Console.WriteLine("Player Stats");
            Console.WriteLine("------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("HP" + ":" + Health);
            Console.WriteLine("Shield" + ":" + Shield);
            Console.WriteLine("Lives" + ":" + Lives);
            Console.WriteLine("Score" + ":" + ScoreMultiplier);
            Console.ResetColor();
        }

        private static void TakeDamage(int healthDamage, int shieldDamage = 0, int livesLeft = 0)
        {
            Health -= healthDamage;
            Shield -= shieldDamage;
            Lives -= livesLeft;
            ShowHUD();
        }

        private static void AddScore(int pointsEarned, float scoreMultiplier)
        {
            ScoreMultiplier += pointsEarned * scoreMultiplier;
            ShowHUD();
        }
    }
}
