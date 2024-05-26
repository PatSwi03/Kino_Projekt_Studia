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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection(@"SERVER=localhost; DATABASE=Kino; UID=root; PASSWORD=''");
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Login użytkownika
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            //Tło aplikacji logowanie
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            //Logo Kina
        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            //Obrazek postać logowania
        }

        public void user_pas_TextChanged(object sender, EventArgs e)
        {
            //haslo użytkownia
        }        
        private void Zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Obrazek kłódka
        }

        private void zalogujsie(object sender, EventArgs e)
        {
            int i = 0;
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT User_name, User_pass FROM users WHERE User_name ='" + user_log.Text + "' AND User_Pass ='" + user_pas.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Zle dane logowania");
            }
            else
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            conn.Close();

        }
    }
}

