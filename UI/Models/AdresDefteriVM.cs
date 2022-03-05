using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class AdresDefteriVM
    {
        [MaxLength(250)]
        public string Adres { get; set; }
        [MaxLength(100)]
        public string Mail { get; set; }
        [MaxLength(250)]
        public string Konum { get; set; }
        public int KisiId { get; set; }
        public List<KisiVM> Kisiler { get; set; }
    }
}
