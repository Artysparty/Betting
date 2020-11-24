using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Betting.Data.Models
{
    public class Teams
    {
        public Teams()
        {
            this.Players = new HashSet<Players>();
            this.HomeGames = new HashSet<Games>();
            this.AwayGames = new HashSet<Games>();
        }
        [Key]
        public int TeamId { get; set; }
        public float Budget { get; set; }
        public string Initials { get; set; }
        [Required, MaxLength]
        public string LogoUrl { get; set; }
        
        [ForeignKey(nameof(PrimaryKitColor))]
        public int PrimaryKitColorId { get; set; }
        [ForeignKey(nameof(SecondaryKitColor))]
        public int SecondaryKitColorId { get; set; }

        [Required, MaxLength(128)]
        public string Name { get; set; }

        public Colors PrimaryKitColor { get; set; }
        public Colors SecondaryKitColor { get; set; }
        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }
        public virtual Towns Town { get; set; }
        public virtual ICollection<Players> Players { get; set; }
        public virtual ICollection<Games> HomeGames { get; set; }
        public virtual ICollection<Games> AwayGames { get; set; }

    }
}
