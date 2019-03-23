using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pera
{
    class Magaza_Urun
    {
        [Key]
        public int ID { get; set; }
        public Urun Urun { get; set; }
        public Magaza Magaza { get; set; }
        public int Miktar { get; set; }
    }
}
