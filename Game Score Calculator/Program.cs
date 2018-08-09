using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Score_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add player names to list
            List<Player> players = new List<Player>();
            List<Player> finalists = new List<Player>();
            Console.WriteLine("Please enter the number of players");
            int numPlayers = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i <numPlayers; i++)
            {
                Console.WriteLine("Please enter the name of a player");
                string name = Console.ReadLine();
                Player player = new Player(name);
                players.Add(player);
            }
            //set maxScore value
            int maxScore = 0;

            int counter = 1;
            while (maxScore < 17)
            {
                Console.WriteLine("Entering scores for round {0}", counter);   
                Console.WriteLine("Which player had the bumper crop?");
                string bumperCrop = Console.ReadLine();
                Console.WriteLine("Which player was Sunkissed?");
                string sunKissed = Console.ReadLine();
                Console.WriteLine("Which player was Frost Bitten?");
                string frostBitten = Console.ReadLine();
                
                for (int j = 0; j < numPlayers; j++)
                {
                    Console.WriteLine("How many fool cards did {0} have?", players[j].Name);
                    int foolCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many okus tokens did {0} have?", players[j].Name);
                    int okusCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many luminary cards did {0} have?", players[j].Name);
                    int luminaryCount = Convert.ToInt32(Console.ReadLine());

                    if (bumperCrop == players[j].Name)
                    {
                        players[j].Score += 4;
                    }
                    if (sunKissed == players[j].Name)
                    {
                        players[j].Score += 2;
                    }
                    if (frostBitten == players[j].Name)
                    {
                        players[j].Score -= 2;
                    }
                    players[j].Score += foolCount + okusCount + luminaryCount;

                    Console.WriteLine("{0}'s score is {1}. ", players[j].Name, players[j].Score);
                }
                maxScore= players.Max(x => x.Score);
                Console.WriteLine("The current max score is {0}", maxScore);
                counter++;
            }
            
            
            
            if(maxScore >= 17)
            {
                foreach (Player player in players)
                {
                    if (player.Score == maxScore)
                    {
                        Console.WriteLine("{0} wins with a score of {1}", player.Name, player.Score);
                    }
                }
            }
            


            Console.Read();
        }
    }
}
