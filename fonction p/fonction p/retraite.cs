using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fonction_p
{
    public partial class retraite : UserControl
    {
        MySqlConnection cn = new MySqlConnection("datasource = localhost; port=3306; database=retraite; UID=root;pwd=");
       // MySqlCommand cmd;
       // MySqlDataReader dr;
        public retraite()
        {
            InitializeComponent();
        }

        private void retraite_Load(object sender, EventArgs e)
        {
            DateTime today = Convert.ToDateTime(datedujour.Value); //Convert.ToDateTime(textBox1.Text); // anné actuel
            int anne = today.Year; // anné actuel + durre
            int mois = today.Month;
            int jour = today.Day;
            string b = jour + " / " + mois + " / " + anne;
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `agent` WHERE `retraite`>='" + b + "'", cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dtgvretraite.DataSource = dtbl;
            cn.Close();
        }
    }
}
