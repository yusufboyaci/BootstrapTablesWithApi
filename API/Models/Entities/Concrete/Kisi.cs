using API.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.Concrete
{
    public class Kisi : BaseEntity
    {
        [MaxLength(50)]
        public string Ad { get; set; }
        [MaxLength(50)]
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public virtual IEnumerable<AdresDefteri> AdresDefterleri { get; set; }
    }
}
