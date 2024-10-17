namespace _2143_stoktakipprogrami
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdSatilanUrunler = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSatisToplam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grdSatislar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdSatislar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SATIŞ LİSTESİ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSatisIptal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSatisToplam);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.grdSatilanUrunler);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(405, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 248);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Satış Detayları";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATILAN ÜRÜNLER";
            // 
            // grdSatilanUrunler
            // 
            this.grdSatilanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatilanUrunler.Location = new System.Drawing.Point(32, 56);
            this.grdSatilanUrunler.Name = "grdSatilanUrunler";
            this.grdSatilanUrunler.Size = new System.Drawing.Size(326, 99);
            this.grdSatilanUrunler.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(362, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "$";
            // 
            // txtSatisToplam
            // 
            this.txtSatisToplam.Location = new System.Drawing.Point(281, 216);
            this.txtSatisToplam.Name = "txtSatisToplam";
            this.txtSatisToplam.Size = new System.Drawing.Size(76, 20);
            this.txtSatisToplam.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(156, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Satış Toplam Fiyat :";
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisIptal.ImageKey = "Ekran görüntüsü 2024-10-17 102003.png";
            this.btnSatisIptal.ImageList = this.ımageList1;
            this.btnSatisIptal.Location = new System.Drawing.Point(20, 209);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(130, 33);
            this.btnSatisIptal.TabIndex = 29;
            this.btnSatisIptal.Text = "SATIŞI İPTAL ET";
            this.btnSatisIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatisIptal.UseVisualStyleBackColor = true;
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
            this.ımageList1.Images.SetKeyName(8, "Ekran görüntüsü 2024-10-17 102003.png");
            // 
            // grdSatislar
            // 
            this.grdSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatislar.Location = new System.Drawing.Point(0, 37);
            this.grdSatislar.Name = "grdSatislar";
            this.grdSatislar.Size = new System.Drawing.Size(399, 251);
            this.grdSatislar.TabIndex = 24;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 304);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdSatilanUrunler;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSatisToplam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdSatislar;
        private System.Windows.Forms.ImageList ımageList1;
    }
}