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
    public partial class Form2 : Form
    {
        public WyswietlData Ddata;
        public Cinema cinema;

        public Form2()
        {
            InitializeComponent();
            Ddata = new WyswietlData();
            cinema = new Cinema("KinoProjekt", "Chorzów WSB");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = Ddata.GetCurrentDateTime();
            textBox4.Text = cinema.Gdziekino();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //logo naszego kina
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
