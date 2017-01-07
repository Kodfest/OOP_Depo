using System.Windows.Forms;

namespace KentKart
{
    class OgretmenKart : Kart
    {
        public override void Okut()
        {
            MessageBox.Show("2 ₺ alındı. Kalan Bakiye : " + (bakiye - 2));
            bakiye -= 2;
        }
    }
}
