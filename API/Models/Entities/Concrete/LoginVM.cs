using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.Concrete
{
    [NotMapped]
    public class LoginVM
    {
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(10)]
        public string Password { get; set; }
    }
}
