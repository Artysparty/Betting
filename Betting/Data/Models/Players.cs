using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Betting.Data.Models
{
    public class Players
    {
        public Players()
        {
            this.PlayerStatistics = new HashSet<PlayerStatistics>();
        }
        [Key]
        public int PlayerId { get; set; }
        public bool IsInjured { get; set; }
        [Required, MaxLength(64)]
        public string Name { get; set; }
        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }
        public int SquadNumber { get; set; }
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual Teams Team { get; set; }
        public virtual Positions Position { get; set; }
        public virtual ICollection<PlayerStatistics> PlayerStatistics{ get; set; }

    }  
}
