using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Colors
    {
        public Colors()
        {
            this.PrimaryKitColor = new HashSet<Teams>();
            this.SecondaryKitColor = new HashSet<Teams>();
        }
        [Key]
        public int ColorId { get; set; }
        [Required, MaxLength(64)]
        public string Name { get; set; }
        [NotMapped]
        public virtual ICollection<Teams> PrimaryKitColor { get; set; }
        [NotMapped]
        public virtual ICollection<Teams> SecondaryKitColor { get; set; }

    }
}
