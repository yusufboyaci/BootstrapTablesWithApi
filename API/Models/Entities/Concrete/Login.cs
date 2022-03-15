using API.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.Concrete
{
    public class Login : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual Kisi Kisi { get; set; }
    }
}
