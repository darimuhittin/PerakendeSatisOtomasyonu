using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pera
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var ctx = new PerakendeContext())
            {
                var YeniMusteri = new Musteri() { Ad = "Muhittin", Soyad ="Darı"};
                //var Urun = new Urun() { Fiyat = 314 };
                //var Calisan = new Calisan() { Pozisyon = "Tezgahtar" };
                //var Saglayici = new Saglayici() { Il = "Yozgat" };

                //List<Urun> yeniUrunler = new List<Urun>();
                //yeniUrunler.Add(Urun);
                //var Stok = new Stok() { StokUrunleri = yeniUrunler };
                //var Magaza = new Magaza() { MagazaStok = Stok };

                ctx.Musteriler.Add(YeniMusteri);
                //ctx.Urunler.Add(Urun);
                //ctx.Calisanlar.Add(Calisan);
                //ctx.Saglayicilar.Add(Saglayici);
                //ctx.Magazalar.Add(Magaza);
                //ctx.Stoklar.Add(Stok);
                ctx.SaveChanges();
            }



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
