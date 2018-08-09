using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Score_Calculator
{
    class Player
    {
        public Player(string name) : this(name, 0)
        {

        }
        public Player(string name, int startingScore)
        {
            Score = startingScore;
            Name = name;
            IsWinner = false;
        }

        //properties
        public int Score { get; set; }
        public string Name { get; set; }
        public bool IsWinner { get; set; }

    }
}

