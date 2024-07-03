using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e) /* Karenin işlemlerini yapacağımız button */
        {


            int Kenar1;
            int Alan, Cevre;

            Kenar1 = Convert.ToInt32(textBox1.Text); /* String'den İnt verisine çeviriyoruz. */

            Cevre = 4 * Kenar1; /* Matematiksel cevre ve alan işlemleri. */
            Alan = Kenar1 * Kenar1;


            KareHesapla kareHesapla = new KareHesapla(); /* Form2'yi form1'e tanımlıyoruz. Bu sayede hem form2 pencere olarak açılacak hemde veri alışverişi yapabiliçez. */


            kareHesapla.AlanHesapla = Alan; /* Form2'ye gönderileçek alan ve cevre sonucu. */
            kareHesapla.CevreHesapla = Cevre;

            kareHesapla.Show(); /* Ekranda form2 penceremizin gözükmesi için gerekli. */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Kenar1, Kenar2;

            int Alan, Cevre;

            Kenar1 = Convert.ToInt32(textBox1.Text);
            Kenar2 = Convert.ToInt32(textBox2.Text);

            Cevre = (2 * Kenar1) + (2 * Kenar2);
            Alan = Kenar1 * Kenar2;

            DikDörtgenHesapla dikDörtgenHesapla = new DikDörtgenHesapla(); /* Buradan methot alıyoruz. */

            dikDörtgenHesapla.DikdötgenCevre = Cevre;
            dikDörtgenHesapla.DikdötgenAlan = Alan;

            dikDörtgenHesapla.Show();

        }


    }
}




