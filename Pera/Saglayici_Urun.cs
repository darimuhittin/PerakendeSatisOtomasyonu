using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pera
{
    class Saglayici_Urun
    {
        [Key]
        public int ID { get; set; }
        public Urun Urun { get; set; }
        public Saglayici Saglayici { get; set; }
    }
}
