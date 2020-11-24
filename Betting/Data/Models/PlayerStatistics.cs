using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class PlayerStatistics
    {
        [ForeignKey(nameof(Player))]
        
        public int PlayerId { get; set; }
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public int Assists { get; set; }
        public float MinutesPlayed { get; set; }
        public int ScoredGoals { get; set; }

        public Players Player { get; set; }
        public Games Game { get; set; }

    }
}
