using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace fonction_p
{
    public partial class retraiteagnet : Form
    {
        MySqlConnection cn = new MySqlConnection("datasource = localhost; port=3306; database=retraite; UID=root;pwd=");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public retraiteagnet()
        {
            InitializeComponent();
        }

        private void retraiteagnet_Load(object sender, EventArgs e)
        {
            
            //-----------------convrsion date debut----------------------------------
            DateTime aujour = DateTime.Today.Date;
            int annedujou = aujour.Year;
            int moisdujou = aujour.Month;
            int jourdujou = aujour.Day;
            string lab=Convert.ToString (moisdujou);
            //------------------convrsion date fin-----------------------------------jourdujou +'/'+ +'/'+ annedujou 
            cn.Open();
            cmd = new MySqlCommand("SELECT COUNT(retraite) AS nombre FROM `agent`WHERE SUBSTR(retraite,5,3)='" + lab + "'  ", cn);
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
               
                int nombre = dr.GetInt32("nombre");
                string nbr = Convert.ToString(nombre);
                lblnbr.Text = nbr;
            }
            cn.Close();
            this.timer1.Start();
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
                int moisdujour = aujourd.Month;
                int jourdujour = aujourd.Day;
                //---------------------------------------------------------------------
                { //-----------------bloc-------------------------------------------------------------------------------------------
                    if (anne <= annedujour)
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
            //----------------------------------*************************************----------------------------------

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            menu.Visible = true;
            guna2ImageButton1.Visible = false;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            menu.Visible = false;
            guna2ImageButton1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressC.Increment(1);
            this.progressb.Increment(2);
            this.progressa.Increment(3);
            this.proc.Increment(1);
            this.prob.Increment(2);
            this.proa.Increment(3);
            pourcentage1.Text =Convert.ToString (progressa.Value);
            pourcentage2.Text = Convert.ToString(progressb.Value);
            pourcentage3.Text = Convert.ToString(progressC.Value);

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Form form1= new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnreetraite_Click(object sender, EventArgs e)
        {
            
          
        }
    }
}
