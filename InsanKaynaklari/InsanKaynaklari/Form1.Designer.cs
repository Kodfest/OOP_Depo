namespace InsanKaynaklari
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComboBoxElemanTuru = new System.Windows.Forms.ComboBox();
            this.NumTCkimlikNo = new System.Windows.Forms.NumericUpDown();
            this.NumMaas = new System.Windows.Forms.NumericUpDown();
            this.NumSatisAdeti = new System.Windows.Forms.NumericUpDown();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LstBoxCalisanlar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumTCkimlikNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSatisAdeti)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxElemanTuru
            // 
            this.ComboBoxElemanTuru.FormattingEnabled = true;
            this.ComboBoxElemanTuru.Items.AddRange(new object[] {
            "Satış Temsilcisi"});
            this.ComboBoxElemanTuru.Location = new System.Drawing.Point(12, 27);
            this.ComboBoxElemanTuru.Name = "ComboBoxElemanTuru";
            this.ComboBoxElemanTuru.Size = new System.Drawing.Size(151, 21);
            this.ComboBoxElemanTuru.TabIndex = 0;
            // 
            // NumTCkimlikNo
            // 
            this.NumTCkimlikNo.Location = new System.Drawing.Point(12, 68);
            this.NumTCkimlikNo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumTCkimlikNo.Name = "NumTCkimlikNo";
            this.NumTCkimlikNo.Size = new System.Drawing.Size(151, 20);
            this.NumTCkimlikNo.TabIndex = 1;
            // 
            // NumMaas
            // 
            this.NumMaas.DecimalPlaces = 2;
            this.NumMaas.Location = new System.Drawing.Point(12, 107);
            this.NumMaas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumMaas.Name = "NumMaas";
            this.NumMaas.Size = new System.Drawing.Size(151, 20);
            this.NumMaas.TabIndex = 2;
            // 
            // NumSatisAdeti
            // 
            this.NumSatisAdeti.Location = new System.Drawing.Point(13, 145);
            this.NumSatisAdeti.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumSatisAdeti.Name = "NumSatisAdeti";
            this.NumSatisAdeti.Size = new System.Drawing.Size(120, 20);
            this.NumSatisAdeti.TabIndex = 4;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEkle.Location = new System.Drawing.Point(12, 171);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(151, 23);
            this.BtnEkle.TabIndex = 5;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.BackgroundImage")));
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuncelle.Location = new System.Drawing.Point(139, 142);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(24, 23);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Eleman Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "T.C. Kimlik No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Satış Adeti";
            // 
            // LstBoxCalisanlar
            // 
            this.LstBoxCalisanlar.FormattingEnabled = true;
            this.LstBoxCalisanlar.Location = new System.Drawing.Point(178, 13);
            this.LstBoxCalisanlar.Name = "LstBoxCalisanlar";
            this.LstBoxCalisanlar.Size = new System.Drawing.Size(270, 173);
            this.LstBoxCalisanlar.TabIndex = 11;
            this.LstBoxCalisanlar.DoubleClick += new System.EventHandler(this.LstBoxCalisanlar_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 205);
            this.Controls.Add(this.LstBoxCalisanlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.NumSatisAdeti);
            this.Controls.Add(this.NumMaas);
            this.Controls.Add(this.NumTCkimlikNo);
            this.Controls.Add(this.ComboBoxElemanTuru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumTCkimlikNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSatisAdeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxElemanTuru;
        private System.Windows.Forms.NumericUpDown NumTCkimlikNo;
        private System.Windows.Forms.NumericUpDown NumMaas;
        private System.Windows.Forms.NumericUpDown NumSatisAdeti;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LstBoxCalisanlar;
    }
}

