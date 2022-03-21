using API.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.Concrete
{
    public class Login : BaseEntity
    {
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(10)]
        public string Password { get; set; }
    }
}
