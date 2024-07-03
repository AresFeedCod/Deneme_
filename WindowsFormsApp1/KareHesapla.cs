using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class KareHesapla : Form
    {

        public KareHesapla()
        {
            InitializeComponent();
        }
        public int AlanHesapla; /* Verilerimizin formlar arasında taşınması için birer methot oluşturduk. */
        public int CevreHesapla;
        public void label3_Click(object sender, EventArgs e)
        {


        }

        private void KareHesapla_Load(object sender, EventArgs e)
        {
            label3.Text = AlanHesapla.ToString(); /* Dışardan alaçağımız verilerin yazılmasını istediğimiz Araç'ı seçiyoruz.*/
            label4.Text = CevreHesapla.ToString();
        }
    }
}
