using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pera
{
    public partial class AnaPanel : Form
    {
        public AnaPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (PerakendeContext ctx = new PerakendeContext())
            {
                dgwCalisanlar.DataSource = ctx.Calisanlar.ToList();
                dgwMagazalar.DataSource = ctx.Magazalar.ToList();
                dgwSaglayicilar.DataSource = ctx.Saglayicilar.ToList();
                dgwSatislar.DataSource = ctx.Satislar.ToList();
                dgwUrunler.DataSource = ctx.Urunler.ToList();
                
            }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PerakendeContext ctx = new PerakendeContext())
            {
                foreach (DataGridViewRow row in dgwCalisanlar.SelectedRows)
                {
                    int silinecekID = (int)row.Cells["ID"].Value;
                    Calisan silinecekCalisan = ctx.Calisanlar.SingleOrDefault(x => x.ID == silinecekID);
                    ctx.Calisanlar.Remove(silinecekCalisan);
                    ctx.SaveChanges();
                    dgwCalisanlar.DataSource = ctx.Calisanlar;
                }
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalisanEkle formCalisanEkle = new CalisanEkle();
            formCalisanEkle.Show();
        }
        
    }
}
