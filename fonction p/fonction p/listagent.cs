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
    public partial class listagent : UserControl
    {
        MySqlConnection cn = new MySqlConnection("datasource = localhost; port=3306; database=retraite; UID=root;pwd=");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public listagent()
        {
            InitializeComponent();
        }

        private void listagent_Load(object sender, EventArgs e)
        {
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `agent`", cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            guna2DataGridView1.DataSource = dtbl;
            cn.Close();
        }
    }
}
