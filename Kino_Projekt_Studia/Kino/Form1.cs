using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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

            string uzytkownik = user_log.Text;
            string haslo = user_pas.Text;

            if (SprawdzNazweiHaslo(uzytkownik, haslo))
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło", "Błąd logowania");
                return;
            }
        }
        public bool SprawdzNazweiHaslo(string uzytkownik, string haslo)
        {
            if (uzytkownik == "Pracownik" & haslo == "kino123")
                return true;
            else
                return false;

        }
    }
    }

