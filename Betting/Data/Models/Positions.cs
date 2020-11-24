using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Betting.Data.Models
{
    public class Positions
    {
        public Positions()
        {
            this.Players = new HashSet<Players>();
        }
        [Key]
        public int PositionId { get; set; }
        [Required, MaxLength(32)]
        public string Name { get; set; }
        public virtual ICollection<Players> Players { get; set; }
    }
}
