using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pera
{
    class Magaza
    {
        [Key]
        public int ID { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
    }
}
