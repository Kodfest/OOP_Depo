using System.Windows.Forms;

namespace KentKart
{
    public enum YolcuTipi
    {
        Tam,
        Ogrenci,
        Ogretmen
    }
    public class Kart
    {
        public int kartID { get; set; }

        private double _bakiye;
        public double bakiye
        {
            get
            {
                return _bakiye;
            }
            set
            {
                _bakiye = value;
            }
        }
        public YolcuTipi kartTuru { get; set; }

        public virtual void Okut()
        {
            MessageBox.Show("Biniş Başarılı! Kalan Bakiye : " + (bakiye - 3));
            bakiye -= 3;
        }

        public override string ToString()
        {
            return kartID + "\t" + bakiye + "\t" + kartTuru;
        }
    }
}
