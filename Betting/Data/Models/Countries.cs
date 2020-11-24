using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Betting.Data.Models
{
    public class Countries
    {
        public Countries()
        {
            this.Towns = new HashSet<Towns>();
        }
        [Key]
        public int CountryId { get; set; }
        [Required, MaxLength(64)]
        public string Name { get; set; }

        public ICollection<Towns> Towns { get; set; }
    }
}
