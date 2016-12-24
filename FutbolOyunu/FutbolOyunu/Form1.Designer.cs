namespace FutbolOyunu
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTakim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumNo = new System.Windows.Forms.NumericUpDown();
            this.LstBoxOyuncular = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adı : ";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(66, 2);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(120, 20);
            this.TxtAd.TabIndex = 0;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEkle.Location = new System.Drawing.Point(15, 80);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(171, 35);
            this.BtnEkle.TabIndex = 3;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "No :  ";
            // 
            // TxtTakim
            // 
            this.TxtTakim.Location = new System.Drawing.Point(66, 54);
            this.TxtTakim.Name = "TxtTakim";
            this.TxtTakim.Size = new System.Drawing.Size(120, 20);
            this.TxtTakim.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Takımı : ";
            // 
            // NumNo
            // 
            this.NumNo.Location = new System.Drawing.Point(66, 28);
            this.NumNo.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NumNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumNo.Name = "NumNo";
            this.NumNo.Size = new System.Drawing.Size(120, 20);
            this.NumNo.TabIndex = 1;
            this.NumNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LstBoxOyuncular
            // 
            this.LstBoxOyuncular.FormattingEnabled = true;
            this.LstBoxOyuncular.Location = new System.Drawing.Point(193, 4);
            this.LstBoxOyuncular.Name = "LstBoxOyuncular";
            this.LstBoxOyuncular.Size = new System.Drawing.Size(167, 108);
            this.LstBoxOyuncular.TabIndex = 7;
            this.LstBoxOyuncular.DoubleClick += new System.EventHandler(this.LstBoxOyuncular_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 129);
            this.Controls.Add(this.LstBoxOyuncular);
            this.Controls.Add(this.NumNo);
            this.Controls.Add(this.TxtTakim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTakim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumNo;
        private System.Windows.Forms.ListBox LstBoxOyuncular;
    }
}

