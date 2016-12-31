using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SatisTemsilcisi st = new SatisTemsilcisi();
        private void Form1_Load(object sender, EventArgs e)
        {
            NumSatisAdeti.Enabled = false;
            BtnGuncelle.Enabled = false;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            st.elamanTuru = ComboBoxElemanTuru.SelectedItem.ToString();
            st.maas = Convert.ToDouble(NumMaas.Value);
            st.TCkimlikNo = Convert.ToInt32(NumTCkimlikNo.Value);

            LstBoxCalisanlar.Items.Add(st);
        }

        private void LstBoxCalisanlar_DoubleClick(object sender, EventArgs e)
        {
            ComboBoxElemanTuru.Enabled = false;
            NumMaas.Enabled = false;
            NumTCkimlikNo.Enabled = false;

            NumSatisAdeti.Enabled = true;
            BtnGuncelle.Enabled = true;

            st = (SatisTemsilcisi)LstBoxCalisanlar.SelectedItem;

            NumMaas.Value = Convert.ToDecimal(st.maas);
            NumTCkimlikNo.Value = st.TCkimlikNo;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            st = (SatisTemsilcisi)LstBoxCalisanlar.SelectedItem;

            int satisAdeti = Convert.ToInt32(NumSatisAdeti.Value);
            NumMaas.Value = Convert.ToDecimal(st.PrimliMaasHesapla(satisAdeti));
        }
    }
}
