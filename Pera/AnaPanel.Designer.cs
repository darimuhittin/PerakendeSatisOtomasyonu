namespace Pera
{
    partial class AnaPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcBilgi = new System.Windows.Forms.TabControl();
            this.tpCalisanBilgi = new System.Windows.Forms.TabPage();
            this.dgwCalisanlar = new System.Windows.Forms.DataGridView();
            this.contextMenuStripCalisanlar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbFiltre = new System.Windows.Forms.GroupBox();
            this.tbMinMaas = new System.Windows.Forms.TextBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.cbPozisyon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.tbMaxMaas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpMagazaBilgi = new System.Windows.Forms.TabPage();
            this.dgwMagazalar = new System.Windows.Forms.DataGridView();
            this.tpSaglayiciBilgi = new System.Windows.Forms.TabPage();
            this.dgwSaglayicilar = new System.Windows.Forms.DataGridView();
            this.tpSatisBilgi = new System.Windows.Forms.TabPage();
            this.dgwSatislar = new System.Windows.Forms.DataGridView();
            this.tpUrunBilgi = new System.Windows.Forms.TabPage();
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniDosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcBilgi.SuspendLayout();
            this.tpCalisanBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCalisanlar)).BeginInit();
            this.contextMenuStripCalisanlar.SuspendLayout();
            this.gbFiltre.SuspendLayout();
            this.tpMagazaBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMagazalar)).BeginInit();
            this.tpSaglayiciBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSaglayicilar)).BeginInit();
            this.tpSatisBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatislar)).BeginInit();
            this.tpUrunBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBilgi
            // 
            this.tcBilgi.Controls.Add(this.tpCalisanBilgi);
            this.tcBilgi.Controls.Add(this.tpMagazaBilgi);
            this.tcBilgi.Controls.Add(this.tpSaglayiciBilgi);
            this.tcBilgi.Controls.Add(this.tpSatisBilgi);
            this.tcBilgi.Controls.Add(this.tpUrunBilgi);
            this.tcBilgi.Location = new System.Drawing.Point(12, 27);
            this.tcBilgi.Name = "tcBilgi";
            this.tcBilgi.SelectedIndex = 0;
            this.tcBilgi.Size = new System.Drawing.Size(1232, 585);
            this.tcBilgi.TabIndex = 0;
            // 
            // tpCalisanBilgi
            // 
            this.tpCalisanBilgi.BackColor = System.Drawing.Color.Transparent;
            this.tpCalisanBilgi.Controls.Add(this.dgwCalisanlar);
            this.tpCalisanBilgi.Controls.Add(this.gbFiltre);
            this.tpCalisanBilgi.Location = new System.Drawing.Point(4, 22);
            this.tpCalisanBilgi.Name = "tpCalisanBilgi";
            this.tpCalisanBilgi.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalisanBilgi.Size = new System.Drawing.Size(1224, 559);
            this.tpCalisanBilgi.TabIndex = 0;
            this.tpCalisanBilgi.Text = "Çalışanlar";
            // 
            // dgwCalisanlar
            // 
            this.dgwCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCalisanlar.ContextMenuStrip = this.contextMenuStripCalisanlar;
            this.dgwCalisanlar.Location = new System.Drawing.Point(6, 104);
            this.dgwCalisanlar.Name = "dgwCalisanlar";
            this.dgwCalisanlar.Size = new System.Drawing.Size(955, 445);
            this.dgwCalisanlar.TabIndex = 7;
            // 
            // contextMenuStripCalisanlar
            // 
            this.contextMenuStripCalisanlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.contextMenuStripCalisanlar.Name = "contextMenuStripCalisanlar";
            this.contextMenuStripCalisanlar.Size = new System.Drawing.Size(181, 92);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // gbFiltre
            // 
            this.gbFiltre.Controls.Add(this.tbMinMaas);
            this.gbFiltre.Controls.Add(this.btnFiltrele);
            this.gbFiltre.Controls.Add(this.cbPozisyon);
            this.gbFiltre.Controls.Add(this.label1);
            this.gbFiltre.Controls.Add(this.tbAd);
            this.gbFiltre.Controls.Add(this.tbMaxMaas);
            this.gbFiltre.Controls.Add(this.label2);
            this.gbFiltre.Controls.Add(this.label5);
            this.gbFiltre.Controls.Add(this.tbSoyad);
            this.gbFiltre.Controls.Add(this.label4);
            this.gbFiltre.Controls.Add(this.label3);
            this.gbFiltre.Location = new System.Drawing.Point(6, 6);
            this.gbFiltre.Name = "gbFiltre";
            this.gbFiltre.Size = new System.Drawing.Size(567, 92);
            this.gbFiltre.TabIndex = 5;
            this.gbFiltre.TabStop = false;
            this.gbFiltre.Text = "Filtre Uygula";
            // 
            // tbMinMaas
            // 
            this.tbMinMaas.Location = new System.Drawing.Point(251, 25);
            this.tbMinMaas.Name = "tbMinMaas";
            this.tbMinMaas.Size = new System.Drawing.Size(100, 20);
            this.tbMinMaas.TabIndex = 1;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(389, 52);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(173, 23);
            this.btnFiltrele.TabIndex = 2;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            // 
            // cbPozisyon
            // 
            this.cbPozisyon.FormattingEnabled = true;
            this.cbPozisyon.Location = new System.Drawing.Point(441, 25);
            this.cbPozisyon.Name = "cbPozisyon";
            this.cbPozisyon.Size = new System.Drawing.Size(121, 21);
            this.cbPozisyon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(56, 22);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(100, 20);
            this.tbAd.TabIndex = 1;
            // 
            // tbMaxMaas
            // 
            this.tbMaxMaas.Location = new System.Drawing.Point(251, 48);
            this.tbMaxMaas.Name = "tbMaxMaas";
            this.tbMaxMaas.Size = new System.Drawing.Size(100, 20);
            this.tbMaxMaas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pozisyon";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(56, 48);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbSoyad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Max Maaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Min Maaş";
            // 
            // tpMagazaBilgi
            // 
            this.tpMagazaBilgi.Controls.Add(this.dgwMagazalar);
            this.tpMagazaBilgi.Location = new System.Drawing.Point(4, 22);
            this.tpMagazaBilgi.Name = "tpMagazaBilgi";
            this.tpMagazaBilgi.Size = new System.Drawing.Size(1212, 372);
            this.tpMagazaBilgi.TabIndex = 1;
            this.tpMagazaBilgi.Text = "Mağazalar";
            this.tpMagazaBilgi.UseVisualStyleBackColor = true;
            // 
            // dgwMagazalar
            // 
            this.dgwMagazalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMagazalar.Location = new System.Drawing.Point(3, 81);
            this.dgwMagazalar.Name = "dgwMagazalar";
            this.dgwMagazalar.Size = new System.Drawing.Size(1206, 288);
            this.dgwMagazalar.TabIndex = 0;
            // 
            // tpSaglayiciBilgi
            // 
            this.tpSaglayiciBilgi.Controls.Add(this.dgwSaglayicilar);
            this.tpSaglayiciBilgi.Location = new System.Drawing.Point(4, 22);
            this.tpSaglayiciBilgi.Name = "tpSaglayiciBilgi";
            this.tpSaglayiciBilgi.Size = new System.Drawing.Size(1212, 372);
            this.tpSaglayiciBilgi.TabIndex = 2;
            this.tpSaglayiciBilgi.Text = "Sağlayıcılar";
            this.tpSaglayiciBilgi.UseVisualStyleBackColor = true;
            // 
            // dgwSaglayicilar
            // 
            this.dgwSaglayicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSaglayicilar.Location = new System.Drawing.Point(3, 63);
            this.dgwSaglayicilar.Name = "dgwSaglayicilar";
            this.dgwSaglayicilar.Size = new System.Drawing.Size(1206, 306);
            this.dgwSaglayicilar.TabIndex = 0;
            // 
            // tpSatisBilgi
            // 
            this.tpSatisBilgi.Controls.Add(this.dgwSatislar);
            this.tpSatisBilgi.Location = new System.Drawing.Point(4, 22);
            this.tpSatisBilgi.Name = "tpSatisBilgi";
            this.tpSatisBilgi.Size = new System.Drawing.Size(1212, 372);
            this.tpSatisBilgi.TabIndex = 3;
            this.tpSatisBilgi.Text = "Satışlar";
            this.tpSatisBilgi.UseVisualStyleBackColor = true;
            // 
            // dgwSatislar
            // 
            this.dgwSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSatislar.Location = new System.Drawing.Point(3, 50);
            this.dgwSatislar.Name = "dgwSatislar";
            this.dgwSatislar.Size = new System.Drawing.Size(1206, 319);
            this.dgwSatislar.TabIndex = 0;
            // 
            // tpUrunBilgi
            // 
            this.tpUrunBilgi.Controls.Add(this.dgwUrunler);
            this.tpUrunBilgi.Location = new System.Drawing.Point(4, 22);
            this.tpUrunBilgi.Name = "tpUrunBilgi";
            this.tpUrunBilgi.Size = new System.Drawing.Size(1212, 372);
            this.tpUrunBilgi.TabIndex = 4;
            this.tpUrunBilgi.Text = "Ürünler";
            this.tpUrunBilgi.UseVisualStyleBackColor = true;
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.Location = new System.Drawing.Point(3, 57);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.Size = new System.Drawing.Size(1206, 312);
            this.dgwUrunler.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiView,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.çıkışToolStripMenuItem});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(51, 20);
            this.tsmiFile.Text = "Dosya";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniDosyaToolStripMenuItem});
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            // 
            // yeniDosyaToolStripMenuItem
            // 
            this.yeniDosyaToolStripMenuItem.Name = "yeniDosyaToolStripMenuItem";
            this.yeniDosyaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.yeniDosyaToolStripMenuItem.Text = "Yeni Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(61, 20);
            this.tsmiEdit.Text = "Düzenle";
            // 
            // tsmiView
            // 
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(70, 20);
            this.tsmiView.Text = "Görünüm";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(56, 20);
            this.tsmiHelp.Text = "Yardım";
            this.tsmiHelp.ToolTipText = "A";
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 610);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tcBilgi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcBilgi.ResumeLayout(false);
            this.tpCalisanBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCalisanlar)).EndInit();
            this.contextMenuStripCalisanlar.ResumeLayout(false);
            this.gbFiltre.ResumeLayout(false);
            this.gbFiltre.PerformLayout();
            this.tpMagazaBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMagazalar)).EndInit();
            this.tpSaglayiciBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSaglayicilar)).EndInit();
            this.tpSatisBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatislar)).EndInit();
            this.tpUrunBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcBilgi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yeniDosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.TabPage tpCalisanBilgi;
        private System.Windows.Forms.DataGridView dgwCalisanlar;
        private System.Windows.Forms.GroupBox gbFiltre;
        private System.Windows.Forms.TextBox tbMinMaas;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.ComboBox cbPozisyon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.TextBox tbMaxMaas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpMagazaBilgi;
        private System.Windows.Forms.TabPage tpSaglayiciBilgi;
        private System.Windows.Forms.TabPage tpSatisBilgi;
        private System.Windows.Forms.TabPage tpUrunBilgi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCalisanlar;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwMagazalar;
        private System.Windows.Forms.DataGridView dgwSaglayicilar;
        private System.Windows.Forms.DataGridView dgwSatislar;
        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
    }
}

