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
        static void Main(string[] args)
        {

            Console.WriteLine("WELCOME TO CAVE ESCAPE");
            Console.WriteLine("----------------------");

            int Health;
            int Shield;
            int Lives;

            float ScoreMultiplier;

            Health = 100;
            Shield = 50;
            Lives = 1;
            ScoreMultiplier = 0f;


            Console.WriteLine("Player Stats");
            Console.WriteLine("------------");


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("HP" + ":" + Health);
            Console.WriteLine("Shield" + ":" + Shield);
            Console.WriteLine("Lives" + ":" + Lives);
            Console.WriteLine("Score" + ":" + ScoreMultiplier);
            Console.ResetColor();

            Console.WriteLine("------------");
            Console.WriteLine("START GAME");
            Console.WriteLine("");

            Console.WriteLine("You Awaken in a dark cave, cold and damp. Torch in hand, you begen your perilous journey back to the surface.");

            Console.WriteLine("As you enter a new part of the cave, you come across a goblin with an old rusty sword");
            Console.WriteLine("");
            Console.WriteLine("- It Attacks You!");

            Console.WriteLine("You take 30 direct damage");
            Console.WriteLine("");
            Console.WriteLine("------------");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("HP" + ":" + (Health - 30));
            
            Console.ResetColor();
            Console.WriteLine("------------");
            Console.WriteLine("");
            Console.WriteLine("- You do a counter attack and kill the goblin!");
            Console.WriteLine("");
            Console.WriteLine("------------");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Score" + ":" + (ScoreMultiplier + 15.5));
            Console.ResetColor();
            
            Console.WriteLine("------------");
            Console.WriteLine("");
            Console.WriteLine("You come across an underwater waterfall inside the cave. You see a Giant back emerge from behind the waterfall!");
            Console.WriteLine("It spits mutated acid at you!");
            Console.WriteLine("");
            Console.WriteLine("------------");
           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("HP" + ":" + (Health - 50));
            Console.WriteLine("Shield" + ":" + (Shield - 20));
            Console.ResetColor();
            
            Console.WriteLine("------------");
            Console.WriteLine("");
            Console.WriteLine("The bat flys away before you can attack it!");
            Console.WriteLine("");
            Console.WriteLine("After a long journey to the surface, you begin to see the light from the sun on the cold cave rocks.");
            Console.WriteLine("Just before you reach the exit, a huge troll blocks your path. It roars and swings it's massive club right on top of you, ending your journey!");
            Console.WriteLine("");
            Console.WriteLine("------------");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("HP" + ":" + (Health - 100));
            Console.WriteLine("Shield" + ":" + (Shield - 50));
            Console.WriteLine("Lives" + ":" + (Lives - 1));
            Console.ResetColor();
           
            Console.WriteLine("------------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.ResetColor();


            Console.ReadKey(true);
        }
    }
}
