using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pera
{
    class Calisan
    {
        [Key]
        public int ID { get; set; }
        public string TCNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
        public string Mail { get; set; }
        public string Pozisyon { get; set; }
        public bool Yetki { get; set; }
        public double Maas { get; set; }
    }
}
