namespace _2143_stoktakipprogrami
{
    partial class Form7
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
            System.Windows.Forms.DataGridView dataGridView1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTedarikci = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUrun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMusteri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPersonelAdSoyad = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYetki = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTxtMusteriTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTedarikci,
            this.menuUrun,
            this.menuSatis,
            this.menuMusteri,
            this.menuPersonel,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.lblPersonelAdSoyad,
            this.yetkiToolStripMenuItem,
            this.lblYetki});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTedarikci
            // 
            this.menuTedarikci.Name = "menuTedarikci";
            this.menuTedarikci.Size = new System.Drawing.Size(112, 20);
            this.menuTedarikci.Text = "Tedarikci islemleri";
            // 
            // menuUrun
            // 
            this.menuUrun.Name = "menuUrun";
            this.menuUrun.Size = new System.Drawing.Size(92, 20);
            this.menuUrun.Text = "Ürün islemleri";
            // 
            // menuSatis
            // 
            this.menuSatis.Name = "menuSatis";
            this.menuSatis.Size = new System.Drawing.Size(91, 20);
            this.menuSatis.Text = "Satış detayları";
            // 
            // menuMusteri
            // 
            this.menuMusteri.Name = "menuMusteri";
            this.menuMusteri.Size = new System.Drawing.Size(106, 20);
            this.menuMusteri.Text = "Müşteri İşlemleri";
            // 
            // menuPersonel
            // 
            this.menuPersonel.Name = "menuPersonel";
            this.menuPersonel.Size = new System.Drawing.Size(111, 20);
            this.menuPersonel.Text = "Personel İşlemleri";
            this.menuPersonel.Click += new System.EventHandler(this.personelİşlemleriToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNot);
            this.groupBox1.Controls.Add(this.txtGenelToplam);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSatisYap);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(dataGridView1);
            this.groupBox1.Controls.Add(this.btnMusteriSec);
            this.groupBox1.Controls.Add(this.txtMusteriAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mskTxtMusteriTelefon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(352, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 385);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SATIŞ İŞLEMİ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem2.Text = "  ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem3.Text = "  ";
            // 
            // lblPersonelAdSoyad
            // 
            this.lblPersonelAdSoyad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPersonelAdSoyad.Name = "lblPersonelAdSoyad";
            this.lblPersonelAdSoyad.Size = new System.Drawing.Size(83, 20);
            this.lblPersonelAdSoyad.Text = "personel adı";
            // 
            // yetkiToolStripMenuItem
            // 
            this.yetkiToolStripMenuItem.Name = "yetkiToolStripMenuItem";
            this.yetkiToolStripMenuItem.Size = new System.Drawing.Size(22, 20);
            this.yetkiToolStripMenuItem.Text = " ";
            this.yetkiToolStripMenuItem.Click += new System.EventHandler(this.yetkiToolStripMenuItem_Click);
            // 
            // lblYetki
            // 
            this.lblYetki.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(44, 20);
            this.lblYetki.Text = "yetki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Müşteri Telefon :";
            // 
            // mskTxtMusteriTelefon
            // 
            this.mskTxtMusteriTelefon.Location = new System.Drawing.Point(136, 33);
            this.mskTxtMusteriTelefon.Mask = "(999) 000-0000";
            this.mskTxtMusteriTelefon.Name = "mskTxtMusteriTelefon";
            this.mskTxtMusteriTelefon.Size = new System.Drawing.Size(100, 20);
            this.mskTxtMusteriTelefon.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Müşteri :";
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.Enabled = false;
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(136, 67);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAdSoyad.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridView1.Location = new System.Drawing.Point(80, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(502, 150);
            dataGridView1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(77, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "SATIŞI YAPILACAK ÜRÜNLER";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(174, 293);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(172, 43);
            this.txtNot.TabIndex = 22;
            this.txtNot.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(104, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Not Ekle :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(209, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Genel Toplam :";
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Enabled = false;
            this.txtGenelToplam.Location = new System.Drawing.Point(314, 359);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(76, 20);
            this.txtGenelToplam.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(395, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "$";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kod";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Miktar";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Birim Fiyat";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Toplam";
            this.Column7.Name = "Column7";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "image1.png");
            this.ımageList1.Images.SetKeyName(1, "image2.png");
            this.ımageList1.Images.SetKeyName(2, "image3.png");
            this.ımageList1.Images.SetKeyName(3, "image4.png");
            this.ımageList1.Images.SetKeyName(4, "Ekran görüntüsü 2024-10-17 100541.png");
            this.ımageList1.Images.SetKeyName(5, "Ekran görüntüsü 2024-10-17 100603.png");
            this.ımageList1.Images.SetKeyName(6, "Ekran görüntüsü 2024-10-17 100617.png");
            this.ımageList1.Images.SetKeyName(7, "Ekran görüntüsü 2024-10-17 100705.png");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(12, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 386);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "Ekran görüntüsü 2024-10-17 100617.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(6, 219);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(68, 34);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisYap.ImageKey = "Ekran görüntüsü 2024-10-17 100541.png";
            this.btnSatisYap.ImageList = this.ımageList1;
            this.btnSatisYap.Location = new System.Drawing.Point(107, 347);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(98, 32);
            this.btnSatisYap.TabIndex = 24;
            this.btnSatisYap.Text = "SATIŞ EKLE";
            this.btnSatisYap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.ImageKey = "Ekran görüntüsü 2024-10-17 100603.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(6, 168);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(68, 35);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriSec.ImageKey = "Ekran görüntüsü 2024-10-17 100705.png";
            this.btnMusteriSec.ImageList = this.ımageList1;
            this.btnMusteriSec.Location = new System.Drawing.Point(242, 31);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(66, 35);
            this.btnMusteriSec.TabIndex = 17;
            this.btnMusteriSec.Text = "SEÇ";
            this.btnMusteriSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(328, 354);
            this.dataGridView2.TabIndex = 25;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form7";
            this.Text = "Form7";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTedarikci;
        private System.Windows.Forms.ToolStripMenuItem menuUrun;
        private System.Windows.Forms.ToolStripMenuItem menuSatis;
        private System.Windows.Forms.ToolStripMenuItem menuMusteri;
        private System.Windows.Forms.ToolStripMenuItem menuPersonel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem lblPersonelAdSoyad;
        private System.Windows.Forms.ToolStripMenuItem yetkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lblYetki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTxtMusteriTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}