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
    public partial class agent : UserControl
    {
        MySqlConnection cn = new MySqlConnection("datasource = localhost; port=3306; database=retraite; UID=root;pwd=");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public agent()
        {
            InitializeComponent();
        }

        private void enregistre_Click(object sender, EventArgs e)
        {
            if (cmbbureau.Text == "" && cmbfonction.Text == "")
            {
                MessageBox.Show("Veiller remplir les informations manquantes ");
            }
            else
            {

                int duree = 65 - Convert.ToInt32(txtage.Text);
                DateTime bdy = new DateTime(duree, 01, 01);
                DateTime today = Convert.ToDateTime(dtenregistrement.Value); //Convert.ToDateTime(textBox1.Text); // anné actuel
                int Age = today.Year + bdy.Year; // anné actuel + durre
                int mois = today.Month;
                int jour = today.Day;
                lbldate.Text = jour + " / " + mois + " / " + Age;
                //-------------------------calcul décompte final----------------------------------------------------------------
                //-------------------------calcul décompte final----------------------------------------------------------------

                cn.Open();
                cmd = new MySqlCommand("SELECT  `salaire` FROM `poste` WHERE `id_poste`='" + cmbfonction.Text + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string salaire = dr.GetString("salaire");
                    string c = salaire;
                    int a = Convert.ToInt32(c) / 10;
                    int b = a * 12;
                    b = b * duree;
                    abc.Text = b.ToString();
                }
                cn.Close();
                cn.Open();
                cmd = new MySqlCommand("INSERT INTO `agent`(`matricule`, `nom`, `postnom`, `age`, `date_engagement`, `duree`, `retraite`, `id_poste`, `decompte`, `id_bureau`) VALUES ('" + txtmatricule.Text + "','" + txtnom.Text + "','" + txtpostnom.Text + "','" + txtage.Text + "','" + dtenregistrement + "','" + duree + "','" + lbldate.Text + "','" + cmbfonction.Text + "','" + abc.Text + "','" + cmbbureau.Text + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("bravos");
                agent_Load(sender, e);
            }
            txtmatricule.Text = "";
            txtage.Text = "";
            txtnom.Text = "";
            txtpostnom.Text = "";
        }
        private void agent_Load(object sender, EventArgs e)
        {
            //  chargement de la combobox poste ocupé par l'agent
            cn.Open();
            cmbfonction.Items.Clear();
            cmbfonction.Items.Add("id_poste");
            cmd = new MySqlCommand("SELECT `id_poste` FROM `poste`", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbfonction.Items.Add(dr[0]);
            }
            cn.Close();
            //  chargement de la combobox poste ocupé par l'agent
            cn.Open();
            cmbbureau.Items.Clear();
            cmbbureau.Items.Add("id_bureau");
            cmd = new MySqlCommand("SELECT `id_bureau` FROM `bureau`", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbbureau.Items.Add(dr[0]);
            }
            cn.Close();

            DateTime dt = Convert.ToDateTime(today.Value.Date);
            //---------------------------------------------------************************--------------------------------------------------------
            cn.Open();
            cmd = new MySqlCommand("SELECT * FROM `agent`", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                string nom = dr.GetString("nom");
                int matricule = dr.GetInt32("matricule");
                string retraite = dr.GetString("retraite");
                string decompte = dr.GetString("decompte");
                string postnom = dr.GetString("postnom");
                string a = nom;
                string b = retraite;
                string c = decompte;
                //-------------------------------------------------------------------
                int d = matricule;

                //---------------------------------------------------------------------
                DateTime dta = Convert.ToDateTime(retraite);
                int anne = dta.Year;
                int mois = dta.Month;
                int jour = dta.Day;
                //----------------------------------------------------------------------
                DateTime aujourd = DateTime.Today.Date;
                int annedujour = aujourd.Year;
                int moisdujour = dta.Month;
                int jourdujour = dta.Day;
                //---------------------------------------------------------------------
                { //-----------------bloc-------------------------------------------------------------------------------------------
                    if (anne > annedujour)
                    {
                        //lbldt.Text = Convert.ToString(dta);

                        //------------------------------------------
                        dtgv.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[5], dr[6]);
                        //--------------------------------------------------
                    }
                    else
                    {

                    }
                }//---------------------------------------fin bloc-----------------------------------------------------------------------
            }
            cn.Close();
            //----------------------------------*************************************------------------------------
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void afficher_Click(object sender, EventArgs e)
        {
            panelagent.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelagent.Visible = false;
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            txtmatricule.Text = "";
            txtage.Text = "";
            txtnom.Text = "";
            txtpostnom.Text = "";
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (cmbbureau.Text == "" && cmbfonction.Text == "")
            {
                MessageBox.Show("Veiller remplir les informations manquantes ");
            }
            else
            {

                int duree = 65 - Convert.ToInt32(txtage.Text);
                DateTime bdy = new DateTime(duree, 01, 01);
                DateTime today = Convert.ToDateTime(dtenregistrement.Value); //Convert.ToDateTime(textBox1.Text); // anné actuel
                int Age = today.Year + bdy.Year; // anné actuel + durre
                int mois = today.Month;
                int jour = today.Day;
                lbldate.Text = jour + " / " + mois + " / " + Age;
                //-------------------------calcul décompte final----------------------------------------------------------------
                //-------------------------calcul décompte final----------------------------------------------------------------

                cn.Open();
                cmd = new MySqlCommand("SELECT  `salaire` FROM `poste` WHERE `id_poste`='" + cmbfonction.Text + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string salaire = dr.GetString("salaire");
                    string c = salaire;
                    int a = Convert.ToInt32(c) / 10;
                    int b = a * 12;
                    b = b * duree;
                    abc.Text = b.ToString();
                }
                cn.Close();
                cn.Open();
                cmd = new MySqlCommand("UPDATE `agent` SET `matricule`='" + txtmatricule.Text + "',`nom`='" + txtnom.Text + "',`postnom`='" + txtpostnom.Text + "',`age`= '" + txtage.Text + "',`date_engagement`='" + dtenregistrement + "',`duree`='" + duree + "',`retraite`='" + lbldate.Text + "',`id_poste`='" + cmbfonction.Text + "',`decompte`='" + abc.Text + "',`id_bureau`='" + cmbbureau.Text + "' WHERE `matricule`='" + txtmatricule.Text + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("bravos");
                agent_Load(sender, e);
            }
            txtmatricule.Text = "";
            txtage.Text = "";
            txtnom.Text = "";
            txtpostnom.Text = "";
        }

        private void txtrecherche_OnTextChange(object sender, EventArgs e)
        {
           
            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new MySqlCommand("SELECT * FROM `agent` WHERE nom='" + txtrecherche.Text + "' ",cn);
            dr = cmd.ExecuteReader();
            //---------------------------------------------------************************--------------------------------------------------------
            while (dr.Read())
            {

                string nom = dr.GetString("nom");
                int matricule = dr.GetInt32("matricule");
                string retraite = dr.GetString("retraite");
                string decompte = dr.GetString("decompte");
                string postnom = dr.GetString("postnom");
                string a = nom;
                string b = retraite;
                string c = decompte;
                //-------------------------------------------------------------------
                int d = matricule;

                //---------------------------------------------------------------------
                DateTime dta = Convert.ToDateTime(retraite);
                int anne = dta.Year;
                int mois = dta.Month;
                int jour = dta.Day;
                //----------------------------------------------------------------------
                DateTime aujourd = DateTime.Today.Date;
                int annedujour = aujourd.Year;
                int moisdujour = dta.Month;
                int jourdujour = dta.Day;
                //---------------------------------------------------------------------
                { //-----------------bloc-------------------------------------------------------------------------------------------
                    if (anne > annedujour)
                    {
                        //lbldt.Text = Convert.ToString(dta);

                        //------------------------------------------
                        dtgv.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[5], dr[6]);
                        //--------------------------------------------------
                    }
                    else
                    {

                    }
                }//---------------------------------------fin bloc-----------------------------------------------------------------------
            } cn.Close();
            agent_Load(sender, e);
            
        }
    }
}


