using Betting.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Betting.Data.Models
{
    public class Bets
    {
        [Key]
        public int BetId { get; set;}
        public float Amount { get; set; }
        [Required, ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public Prediction Prediction { get; set; }
        public DateTime DateTime { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual Games Game { get; set; }
        public virtual Users User { get; set; }
    }
}
