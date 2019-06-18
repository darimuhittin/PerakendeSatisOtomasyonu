namespace Pera
{
    partial class CalisanGuncelle
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTC = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yönetici",
            "Çalışan"});
            this.comboBox2.Location = new System.Drawing.Point(507, 186);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 24);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "Kasa Görevlisi",
            "Reyon Görevlisi",
            "Kasap Görevlisi",
            "Temizlik Görevlisi"});
            this.comboBox1.Location = new System.Drawing.Point(507, 126);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(507, 245);
            this.tbSalary.Margin = new System.Windows.Forms.Padding(4);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(231, 22);
            this.tbSalary.TabIndex = 18;
            this.tbSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalary_KeyPress);
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(117, 186);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(4);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(231, 22);
            this.tbSurname.TabIndex = 16;
            this.tbSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSurname_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(117, 126);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(231, 22);
            this.tbName.TabIndex = 15;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(507, 67);
            this.tbMail.Margin = new System.Windows.Forms.Padding(4);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(231, 22);
            this.tbMail.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(747, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 248);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Maaş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefon :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Yetki :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(507, 318);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(231, 66);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Güncelle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pozisyon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "E - Mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "TC No :";
            // 
            // tbTC
            // 
            this.tbTC.Location = new System.Drawing.Point(117, 67);
            this.tbTC.Margin = new System.Windows.Forms.Padding(4);
            this.tbTC.MaxLength = 11;
            this.tbTC.Name = "tbTC";
            this.tbTC.Size = new System.Drawing.Size(231, 22);
            this.tbTC.TabIndex = 22;
            this.tbTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTC_KeyPress);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(117, 245);
            this.tbPhone.Mask = "(999) 000-0000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(231, 22);
            this.tbPhone.TabIndex = 23;
            // 
            // CalisanGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbTC);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalisanGuncelle";
            this.Text = "CalisanGuncelle";
            this.Load += new System.EventHandler(this.CalisanGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox tbSalary;
        public System.Windows.Forms.TextBox tbSurname;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.TextBox tbTC;
        public System.Windows.Forms.MaskedTextBox tbPhone;
    }
}