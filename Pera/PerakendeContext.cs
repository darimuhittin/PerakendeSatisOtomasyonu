using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pera
{
    class PerakendeContext:DbContext
    {
        public PerakendeContext():base("Server=.;Database=dbPera;Trusted_Connection=True;")
        {

        }

        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Saglayici> Saglayicilar { get; set; }
        public DbSet<Magaza> Magazalar { get; set; }
        public DbSet<Magaza_Urun> MagazaUrunleri { get; set; }
        public DbSet<Saglayici_Urun> SaglayiciUrunleri { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Satis_Urun> SatisUrunleri { get; set; }
    }
}
