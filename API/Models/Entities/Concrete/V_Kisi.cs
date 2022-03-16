using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.Concrete
{
    public class V_Kisi
    {
     
        public int KisiId { get; set; }
        public string AdSoyad { get; set; }
    }
}
