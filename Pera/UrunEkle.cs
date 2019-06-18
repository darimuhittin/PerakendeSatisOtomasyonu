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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        public void settings()
        {
            PerakendeContext context = new PerakendeContext();

            
            string barcode = tbbarcode.Text;
            string category = tbcategory.Text;
            string brand = tbbrand.Text;
            string model = tbmodel.Text;
            string stock =tbstock.Text;
            string weight = tbweight.Text;
            string price = tbprice.Text;
            DateTime skt = SKT.Value;
            DateTime at = AT.Value;

            Urun products = new Urun();
            products.Barkod =barcode.ToString();
            products.Kategori = category;
            products.Marka = brand;
            products.Model = model;
            products.Stok = stock;
            products.Ağırlık = weight;
            products.Fiyat = price;
            products.SKT = skt;
            products.AT = at;
            context.Urunler.Add(products);
            context.SaveChanges();
            MessageBox.Show("Veriler kaydedildi");
            this.Close();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            settings();
        }

        private void tbcategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tbstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tbweight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tbprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
