using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pera
{
    class Urun
    {
        [Key]
        public int ID { get; set; }
        public int BarkodNo { get; set; }
        public int Fiyat { get; set; }
        public string Ad { get; set; }
        public string Agirlik { get; set; }
        public DateTime? SKT { get; set; }
    }
}
