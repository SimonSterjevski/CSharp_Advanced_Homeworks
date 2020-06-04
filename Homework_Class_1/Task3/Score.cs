using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public static class Score
    {
        public static int PlayerWins { get; set; } = 0;
        public static int ComputerWins { get; set; } = 0;
        public static int TotalGamesPlayed { get => PlayerWins + ComputerWins; }
    } 
}
