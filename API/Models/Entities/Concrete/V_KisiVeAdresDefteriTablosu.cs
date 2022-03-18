using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.Concrete
{
    [NotMapped]
    public class V_KisiVeAdresDefteriTablosu
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public string Konum { get; set; }
        public int KisiId { get; set; }
        public string AdSoyad { get; set; }
    }
}
