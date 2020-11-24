using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Betting.Data.Models
{
    public class Users
    {
        public Users()
        {
            this.Bets = new HashSet<Bets>();
        }
        [Key]
        public int UserId { get; set; }
        [Required, MaxLength(64)]
        public string Email { get; set; }
        [Required, MaxLength(64)]
        public string Name { get; set; }
        public float Balance { get; private set; }
        public string Password { get; set; }
        [Required, MaxLength(128)]
        public string Username { get; set; }
        public virtual ICollection<Bets> Bets { get; set; }
    }
}
