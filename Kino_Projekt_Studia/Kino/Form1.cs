﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kino
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn = new MySqlConnection(@"SERVER=localhost; DATABASE=Kino; UID=root; PASSWORD=''");
        private User user = new User("", ""); // Inicjalizacja obiektu User

        public Form1()
        {
            InitializeComponent();
        }
        public class User
        {
            public string UserName { get; set; }
            public string Password { get; set; }

            public User(string userName, string password)
            {
                UserName = userName;
                Password = password;
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Login użytkownika
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Tło aplikacji logowanie
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            // Logo Kina
        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            // Obrazek postać logowania
        }

        public void user_pas_TextChanged(object sender, EventArgs e)
        {
            // Hasło użytkownika
        }

        private void Zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Obrazek kłódka
        }

        private void zalogujsie(object sender, EventArgs e)
        {
            int i = 0;
            user.UserName = user_log.Text;
            user.Password = user_pas.Text;

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT User_name, User_pass FROM users WHERE User_name = @userName AND User_Pass = @password";
            cmd.Parameters.AddWithValue("@userName", user.UserName);
            cmd.Parameters.AddWithValue("@password", user.Password);

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Złe dane logowania");
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
