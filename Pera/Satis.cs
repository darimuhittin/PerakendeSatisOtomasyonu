using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pera
{
    class Satis
    {
        [Key]
        public int ID { get; set; }
        public Magaza Magaza { get; set; }
        public Musteri Musteri { get; set; }
        public DateTime? Tarih { get; set; }
        public int Tutar { get; set; }
    }
}
