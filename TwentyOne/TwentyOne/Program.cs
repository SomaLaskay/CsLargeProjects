using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
 
namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player("Soma");
            const string casinoName = "Grand Hotel and Casino";

            

            Console.WriteLine($"Welcome to the {casinoName}! Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only.");
            }
            
            Console.WriteLine($"Hello {playerName}. Would you like to join a game of 21 right now?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\CsharpDev\Log.txt", true))
                {
                    file.WriteLine($"Player: {playerName} ({player.Id})");
                }
                Game game = new Casino.TwentyOne.TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Please wait for security crew to show up and escort you to the nearest exit.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured, please contact your system administrator.");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.ReadLine();
        }


    }
}
