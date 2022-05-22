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
    public partial class tableaux : UserControl
    {
        MySqlConnection cn = new MySqlConnection("datasource = localhost; port=3306; database=retraite; UID=root;pwd=");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public tableaux()
        {
            InitializeComponent();
        }

        private void tableaux_Load(object sender, EventArgs e)
        {
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `agent`", cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dtgvtab.DataSource = dtbl;
            cn.Close();
        }

        private void btnagent_Click(object sender, EventArgs e)
        {
            
            cn.Open();
            MySqlDataAdapter db = new MySqlDataAdapter("SELECT * FROM `agent`", cn);
            DataTable dtbla = new DataTable();
            db.Fill(dtbla);
            dtgvtabagent.DataSource = dtbla;
            cn.Close();
        }

        private void btndirection_Click(object sender, EventArgs e)
        {
            cn.Open();
            MySqlDataAdapter db = new MySqlDataAdapter("SELECT * FROM `direction`", cn);
            DataTable dtbla = new DataTable();
            db.Fill(dtbla);
            dtgvtabagent.DataSource = dtbla;
            cn.Close();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            cn.Open();
            MySqlDataAdapter db = new MySqlDataAdapter("SELECT * FROM `division`", cn);
            DataTable dtbla = new DataTable();
            db.Fill(dtbla);
            dtgvtabagent.DataSource = dtbla;
            cn.Close();
        }

        private void btnservice_Click(object sender, EventArgs e)
        {
            cn.Open();
            MySqlDataAdapter db = new MySqlDataAdapter("SELECT * FROM `sevice`", cn);
            DataTable dtbla = new DataTable();
            db.Fill(dtbla);
            dtgvtabagent.DataSource = dtbla;
            cn.Close();
        }

        private void btnbureau_Click(object sender, EventArgs e)
        {
            cn.Open();
            MySqlDataAdapter db = new MySqlDataAdapter("SELECT * FROM `bureau`", cn);
            DataTable dtbla = new DataTable();
            db.Fill(dtbla);
            dtgvtabagent.DataSource = dtbla;
            cn.Close();
        }

        private void btnministere_Click(object sender, EventArgs e)
        {
            cn.Open();
            MySqlDataAdapter db = new MySqlDataAdapter("SELECT * FROM `ministeres`", cn);
            DataTable dtbla = new DataTable();
            db.Fill(dtbla);
            dtgvtabagent.DataSource = dtbla;
            cn.Close();
        }
    }
}
