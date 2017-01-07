using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Kart yolcu)
        {
            InitializeComponent();
        }

        OgrenciKart ogrenci = new OgrenciKart();
        OgretmenKart ogretmen = new OgretmenKart();
        Kart tam = new Kart();
        int kartid = 1;

        static List<Kart> kaliciListe = new List<Kart>();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (RadioBtnOgrenci.Checked)
            {
                ogrenci.bakiye = Convert.ToDouble(TxtBakiye.Text);
                ogrenci.kartID = kartid;
                kartid++;
                ogrenci.okulAdi = TxtOkulAdi.Text;
                ogrenci.kartTuru = YolcuTipi.Ogrenci;
                LstBoxYolcular.Items.Add(ogrenci);
                kaliciListe.Add(ogrenci);
            }
            else if (RadioBtnOgretmen.Checked)
            {
                ogretmen.bakiye = Convert.ToDouble(TxtBakiye.Text);
                ogretmen.kartID = kartid;
                kartid++;
                ogretmen.kartTuru = YolcuTipi.Ogretmen;
                LstBoxYolcular.Items.Add(ogretmen);
                kaliciListe.Add(ogretmen);
            }
            else if (RadioBtnTam.Checked)
            {
                tam.bakiye = Convert.ToDouble(TxtBakiye.Text);
                tam.kartID = kartid;
                kartid++;
                tam.kartTuru = YolcuTipi.Tam;
                LstBoxYolcular.Items.Add(tam);
                kaliciListe.Add(tam);
            }

            Temizle();
        }

        private void RadioBtnOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            GBoxOkulAdi.Enabled = RadioBtnOgrenci.Checked == true ? true : false;
        }

        public void Temizle()
        {
            TxtBakiye.Clear();
            TxtOkulAdi.Clear();
        }

        private void LstBoxYolcular_DoubleClick(object sender, EventArgs e)
        {
            //var yolcu = LstBoxYolcular.SelectedItem;
            Kart yolcu = (Kart)LstBoxYolcular.SelectedItem;

            if (yolcu.kartTuru == YolcuTipi.Ogrenci && yolcu.bakiye - 1 >= 0)
            {
                LstBoxYolcular.Items.RemoveAt(LstBoxYolcular.SelectedIndex);
                ogrenci = (OgrenciKart)yolcu;
                ogrenci.Okut();
                LstBoxYolcular.Items.Add(ogrenci);
            }
            else if (yolcu.kartTuru == YolcuTipi.Ogretmen && yolcu.bakiye - 2 >= 0)
            {
                LstBoxYolcular.Items.RemoveAt(LstBoxYolcular.SelectedIndex);
                ogretmen = (OgretmenKart)yolcu;
                ogretmen.Okut();
                LstBoxYolcular.Items.Add(ogretmen);
            }
            else if (yolcu.kartTuru == YolcuTipi.Tam && yolcu.bakiye - 3 >= 0)
            {
                LstBoxYolcular.Items.RemoveAt(LstBoxYolcular.SelectedIndex);
                tam = yolcu;
                tam.Okut();
                LstBoxYolcular.Items.Add(tam);
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye!");

                DialogResult result = MessageBox.Show("Bakiye Yüklemek İstermisin?", "Bildirim Ekranı", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Form2 frm = new Form2(yolcu);
                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in kaliciListe)
            {
                LstBoxYolcular.Items.Add(item);
            }
        }
    }
}
