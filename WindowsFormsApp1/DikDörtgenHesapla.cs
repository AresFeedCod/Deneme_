using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DikDörtgenHesapla : Form
    {
        public DikDörtgenHesapla()
        {
            InitializeComponent();
        }
        public int DikdötgenAlan; /* Verilerimizin formlar arasında taşınması için birer methot oluşturduk. */
        public int DikdötgenCevre;
        private void DikDörtgenHesapla_Load(object sender, EventArgs e) /* Genel form perceresine cift tıklayarak açıyoruz. */
        {
            label3.Text = DikdötgenAlan.ToString(); /* Dışardan alaçağımız verilerin yazılmasını istediğimiz Araç'ı seçiyoruz.*/
            label4.Text = DikdötgenCevre.ToString();
        }
    }
}
