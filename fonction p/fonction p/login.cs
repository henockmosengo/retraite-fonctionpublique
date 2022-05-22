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
    public partial class login : Form
    {
        MySqlConnection cn = new MySqlConnection("datasource = localhost; port=3306; database=retraite; UID=root;pwd=");
        public login()
        {
            InitializeComponent();
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            //validation du button login
            int i = 0;
            cn.Open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM `fonction_p` WHERE `id_fonction_p`='" + txtlogin.Text + "' and `identifient`='" + txtmdp.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show(" identifiant et mot de pass invalide");
            }
            else
            {
                this.timer1.Start();
                Form Form1 = new Form1();
                Form1.Show();
                this.Hide();
            }
            cn.Close();
            txtlogin.Text = "";
            txtlogin.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.cercle.Increment(2);
           
        }
    }
}
