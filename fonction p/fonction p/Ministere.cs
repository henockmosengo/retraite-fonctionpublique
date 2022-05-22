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
    public partial class Ministere : UserControl
    {
        MySqlConnection cn = new MySqlConnection("datasource = localhost; port=3306; database=retraite; UID=root;pwd=");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Ministere()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnvalmin_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new MySqlCommand("INSERT INTO `ministeres`(`id_ministere`, `libelle`, `id_fonction_p`) VALUES ('" + txtidmini.Text + "','" + txtlibmini.Text + "','" + idfonctionp.Text + "')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("inscription reussi");
            txtidmini.Text = "";
            txtlibmini.Text = "";
            Ministere_Load(sender, e);
        }

        private void Ministere_Load(object sender, EventArgs e)
        {
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `ministeres`", cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dtgvmin.DataSource = dtbl;
            cn.Close();
            //  chargement de la combobox 
            cn.Open();
            idfonctionp.Items.Clear();
            idfonctionp.Items.Add("id_ministaire");
            cmd = new MySqlCommand("SELECT `id_fonction_p` FROM `fonction_p`", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                idfonctionp.Items.Add(dr[0]);
            }
            cn.Close();
        }
    }
}
