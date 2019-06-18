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
    public partial class UrunGuncelle : Form
    {
        public UrunGuncelle()
        {
            InitializeComponent();
        }
        PerakendeContext context = new PerakendeContext();
       
        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
