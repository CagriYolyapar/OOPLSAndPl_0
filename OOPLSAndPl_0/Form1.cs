using OOPLSAndPl_0.Models;

namespace OOPLSAndPl_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Personel> personeller = new List<Personel>
            {
                new Mudur(),
                new Egitmen(),
                new Danisman()
            };

            foreach (Personel item in personeller)
            {
                MessageBox.Show(item.GorevYap());
            }

           
            
        }
    }
}
