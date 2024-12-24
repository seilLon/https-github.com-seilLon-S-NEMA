using System.Data.SqlClient;

namespace SİNEMA
{
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }
        sqlConnection = new SqlConnection(“Data Source = DESKTOP - GDN4PIU\SQLEXPRESS;Intial Catalog = sinemaDB;Integrated Secruity = True”);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.open();
            if(baglanti.state==ConnectionState.Open)
        }
    }
}
