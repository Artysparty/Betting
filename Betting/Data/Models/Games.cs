using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Betting.Data.Models
{
    public class Games
    {
        public Games()
        {
            this.Bets = new HashSet<Bets>();
            this.PlayerStatistics = new HashSet<PlayerStatistics>();
        }
        [Key]
        public int GameId { get; set; }
        public float AwayTeamBetRate { get; set; }
        public int AwayTeamGoals { get; set; }
        [ForeignKey(nameof(AwayTeam))]
        public int AwayTeamId { get; set; }
        public float DrawBetRate { get; set; }
        public float HomeTeamBetRate { get; set; }
        public int HomeTeamGoals { get; set; }
        [ForeignKey(nameof(HomeTeam))]
        public int HomeTeamId { get; set; }
        public int Result { get; set; }
        public DateTime DateTime { get; set; }
        public virtual ICollection<Bets> Bets { get; set; }
        public virtual ICollection<PlayerStatistics> PlayerStatistics { get; set; }
        public virtual Teams HomeTeam { get; set; }
        public virtual Teams AwayTeam { get; set; }
    }
}
