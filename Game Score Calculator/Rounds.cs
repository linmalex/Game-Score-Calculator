using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Score_Calculator
{
    class Rounds
    {
        public Rounds()
        {
            roundNumber = 1;
            
        }

        public int Score { get; set; }
        public int roundNumber { get; set; }
        public string playerName { get; set; }
    }
}
