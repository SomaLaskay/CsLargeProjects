using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] names = { "Bunny", "Juju", "Zoey", "Theo", "Lora" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}

            //List<int> testScores = new List<int>();
            //testScores.Add(55);
            //testScores.Add(66);
            //testScores.Add(77);

            //foreach (int score in testScores)
            //{
            //    if (score >= 66)
            //    {
            //        Console.WriteLine("Passing score: " + score);
            //    }
            //}

            List<string> persons = new List<string>() { "Imre", "Lajos", "Pista", "Juju" };
            List<string> enemies = new List<string>();

            foreach (string sniff in persons)
            {
                if (sniff == "Juju")
                {
                    Console.WriteLine(sniff + ": LOVE! LOVE! LOVE!");
                }
                else
                {
                    Console.WriteLine(sniff + ": ATTACK! ATTACK! ATTACK!");
                    enemies.Add(sniff);
                }
            }

            Console.WriteLine("Number of enemies: " + enemies.Count );

            Console.ReadLine();

        }
    }
}
