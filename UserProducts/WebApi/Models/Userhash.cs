using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Userhash
    {
        [Key, ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        public string password { get; set; }

        public virtual User User { get; set; }
    }
}
