using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Betting.Data.Models
{
    public class Towns
    {
        public Towns()
        {
            this.Teams = new HashSet<Teams>();
        }
        [Key]
        public int TownId { get; set; }
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        [Required, MaxLength(64)]
        public string Name { get; set; }

        public virtual ICollection<Teams> Teams { get; set; }
        public virtual Countries Country { get; set; }
    }
}
