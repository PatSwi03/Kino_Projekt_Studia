using System;
using System.Windows.Forms;

namespace Kino
{
    public partial class Form5 : Form
    {
        private RoznicaObliczeniaDetaliczna roznicaObliczeniaWaluta;

        public Form5()
        {
            InitializeComponent();
            roznicaObliczeniaWaluta = new RoznicaObliczeniaDetaliczna();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ObliczRoznice();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ObliczRoznice();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ObliczRoznice()
        {
            if (double.TryParse(textBox1.Text, out double value1) && double.TryParse(textBox2.Text, out double value2))
            {
                roznicaObliczeniaWaluta.KwotaDoZaplaty = value1;
                roznicaObliczeniaWaluta.KwotaOtrzymana = value2;

                // Wyświetl kwote do zapłaty z walutą
                textBox3.Text = roznicaObliczeniaWaluta.ObliczRozniceZWaluta();
            }
            else
            {
                // Jeśli wartości nie są liczbowe, wyczyść pole
                textBox3.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
