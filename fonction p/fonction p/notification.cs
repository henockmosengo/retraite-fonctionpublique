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
    public partial class notification : UserControl
    {
        MySqlConnection cn = new MySqlConnection("datasource = localhost; port=3306; database=retraite; UID=root;pwd=");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public notification()
        {
            InitializeComponent();
        }

        private void guna2CircleProgressBar4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void notification_Load(object sender, EventArgs e)
        {
            DateTime today = Convert.ToDateTime(dt.Value.Date);
            /*int annee = today.Year; 
            int mois = today.Month;
            int jour = today.Day;*/
            lbldate.Text = Convert.ToString(today);


            
            this.timer1.Start();
            //---------------------------------***************************-------------------------------------------------
            string date = Convert.ToString(dt.Value);

            /* if (date)
             {
                 lblnom.Text = date;
             }
             else
             {
                 lblnom.Text = "Desolé....";
             }
             */
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
                    if (anne == annedujour)
                    {
                        //lbldt.Text = Convert.ToString(dta);
                        if (mois == moisdujour) { 
                        lblnom.Text = "bravooooooooos";
                        }
                        
                        //------------------------------------------
                        dtvg.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[5], dr[6]);
                        //--------------------------------------------------
                    }
                    else
                    {
                        lblnom.Text = "desolé....";
                    }
                }//---------------------------------------fin bloc-----------------------------------------------------------------------
            }
            cn.Close();
            //----------------------------------*************************************----------------------------------
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            notification_Load(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.guna2CircleProgressBar1.Increment(1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
