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
    
    public partial class formulaire : UserControl
    {
        MySqlConnection cn = new MySqlConnection("datasource = localhost; port=3306; database=retraite; UID=root;pwd=");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public formulaire()
        {
            InitializeComponent();
        }

        private void validedirection_Click(object sender, EventArgs e)
        {
            if (cmbministere.Text == "")
            {
                MessageBox.Show("Veiller remplir les informations manquantes ");
            }
            else
            {
                cn.Open();
                cmd = new MySqlCommand("INSERT INTO `direction`(`id_direction`, `libelle`, `id_ministere`) VALUES('" + txtiddirection.Text + "','" + txtlibservice.Text + "','" + cmbministere.Text + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                formulaire_Load(sender, e);
                MessageBox.Show("direction inscrit");
                txtiddirection.Text = "";
                txtlibservice.Text = "";
            }
        }

        private void formulaire_Load(object sender, EventArgs e)
        {
            //  chargement de la combobox direction
            cn.Open();
            cmbdirection.Items.Clear();
            cmbdirection.Items.Add("Identifiant");
            cmd = new MySqlCommand("SELECT `id_direction` FROM `direction`", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbdirection.Items.Add(dr[0]);
            }
            cn.Close();
            //  chargement de la combobox division
            cn.Open();
            cmbdivision.Items.Clear();
            cmbdivision.Items.Add("id_ministaire");
            cmd = new MySqlCommand("SELECT `id_division` FROM `division`", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbdivision.Items.Add(dr[0]);
            }
            cn.Close();
            //  chargement de la combobox ministere
            cn.Open();
            cmbministere.Items.Clear();
            cmbministere.Items.Add("id_ministaire");
            cmd = new MySqlCommand("SELECT `id_ministere`FROM `ministeres`", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbministere.Items.Add(dr[0]);
            }
            cn.Close();
            //  chargement de la combobox service
            cn.Open();
            cmbservice.Items.Clear();
            cmbservice.Items.Add("id_ministaire");
            cmd = new MySqlCommand("SELECT `id_service` FROM `sevice`", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbservice.Items.Add(dr[0]);
            }
            cn.Close();
        }

        private void validedivision_Click(object sender, EventArgs e)
        {
            if (cmbdirection.Text == "")
            {
                MessageBox.Show("Veiller remplir les informations manquantes ");
            }
            else
            {
                cn.Open();
                cmd = new MySqlCommand("INSERT INTO `division`(`id_division`, `libelle`, `id_direction`) VALUES('" + txtiddivision.Text + "','" + txtlibdivision.Text + "','" + cmbdirection.Text + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("division inscrit");
                formulaire_Load(sender, e);
                txtiddivision.Text = "";
                txtlibdivision.Text = "";
            }
        }

        private void valideservice_Click(object sender, EventArgs e)
        {
            if (cmbdirection.Text == "")
            {
                MessageBox.Show("Veiller remplir les informations manquantes ");
            }
            else
            {
                cn.Open();
                cmd = new MySqlCommand("INSERT INTO `sevice`(`id_service`, `libelle`, `id_division`) VALUES('" + txtidservice.Text + "','" + txtlibservice.Text + "','" + cmbdivision.Text + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                formulaire_Load(sender, e);
                MessageBox.Show("service inscrit");
                txtidservice.Text = "";
                txtlibservice.Text = "";
            }
        }

        private void validebureau_Click(object sender, EventArgs e)
        {
            if (cmbdirection.Text == "")
            {
                MessageBox.Show("Veiller remplir les informations manquantes ");
            }
            else
            {
                cn.Open();
                cmd = new MySqlCommand("INSERT INTO `bureau`(`id_bureau`, `libelle`, `id_service`) VALUES('" + txtidbureau.Text + "','" + txtlibbureau.Text + "','" + cmbservice.Text + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                formulaire_Load(sender, e);
                MessageBox.Show("bureau inscrit");
                txtidbureau.Text = "";
                txtlibbureau.Text = "";
            }
        }

        private void annuleservice_Click(object sender, EventArgs e)
        {

        }
    }
}
