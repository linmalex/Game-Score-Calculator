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
            List<Player> players = new List<Player>();
            Console.WriteLine("Please enter the number of players");
            int numPlayers = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i < numPlayers; i++)
            {
                Console.WriteLine("Please enter the name of a player");
                string name = Console.ReadLine();
                Player player = new Player(name);
                players.Add(player);
            }
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
                
                for (int i = 0; i < numPlayers; i++)
                {
                    Console.WriteLine("How many fool cards did {0} have?", players[i].Name);
                    int foolCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many okus tokens did {0} have?", players[i].Name);
                    int okusCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many luminary cards did {0} have?", players[i].Name);
                    int luminaryCount = Convert.ToInt32(Console.ReadLine());
                    if (bumperCrop == players[i].Name)
                    {
                        players[i].Score += 4;
                    }
                    if (sunKissed == players[i].Name)
                    {
                        players[i].Score += 2;
                    }
                    if (frostBitten == players[i].Name)
                    {
                        players[i].Score -= 2;
                    }
                    players[i].Score += foolCount + okusCount + luminaryCount;
                    Console.WriteLine("{0}'s score is {1}. ", players[i].Name, players[i].Score);
                }
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
