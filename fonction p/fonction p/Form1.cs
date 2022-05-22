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
    public partial class Form1 : Form
    {
        MySqlConnection cn = new MySqlConnection("datasource = localhost; port=3306; database=retraite; UID=root;pwd=");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ministere_Click(object sender, EventArgs e)
        {
            transition.ShowSync(ministere1);
            formulaire1.Visible = false;
            notification1.Visible = false;
            tableaux1.Visible = false;
            agent1.Visible = false;
            retraite1.Visible = false;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //agent bouton
            agent1.Visible = true;
            ministere1.Visible = false;
            formulaire1.Visible = false;
            tableaux1.Visible = false;
            notification1.Visible = false;
            retraite1.Visible = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //retraite bouton
            Form retraiteagnet = new retraiteagnet();
            retraiteagnet.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // formulaire
            transition.ShowSync(formulaire1);
            ministere1.Visible = false;
            notification1.Visible = false;
            tableaux1.Visible = false;
            agent1.Visible = false;
            retraite1.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {  
            ministere1.Visible = false;
            formulaire1.Visible = false;
            notification1.Visible = false;
            agent1.Visible = false;
            transition.ShowSync(tableaux1);
            tableaux1.Visible = true;
            retraite1.Visible = false;
        }

        private void tableaux1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            transition.ShowSync(notification1);
            ministere1.Visible = false;
            formulaire1.Visible = false;
            tableaux1.Visible = false;
            agent1.Visible = false;
            retraite1.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            agent1.Visible = true;
            ministere1.Visible = false;
            formulaire1.Visible = false;
            tableaux1.Visible = false;
            notification1.Visible = false;
            retraite1.Visible = false;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            ministere1.Visible = false;
            formulaire1.Visible = false;
            notification1.Visible = false;
            agent1.Visible = false;
            tableaux1.Visible = false;
            retraite1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            retraite1.Visible = true;
            ministere1.Visible = false;
            formulaire1.Visible = false;
            notification1.Visible = false;
            agent1.Visible = false;
            tableaux1.Visible = false;
        }

        private void btnretraite_Click(object sender, EventArgs e)
        {
            Form retraiteagnet = new retraiteagnet();
            retraiteagnet.Show();
            this.Hide();
        }
    }
}
