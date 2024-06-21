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

namespace Kino
{
    public partial class Form3 : Form
    {
        MySqlConnection conn = new MySqlConnection(@"SERVER=localhost; DATABASE=Kino; UID=root; PASSWORD=''");

        public Form3()
        {
            InitializeComponent();
            LoadData();
            // musi byc textchanged zeby sumowalo sie prawidlowo
            textBox1.TextChanged += dodawanie;
            textBox2.TextChanged += dodawanie;
            textBox3.TextChanged += dodawanie;
            textBox4.TextChanged += dodawanie;
            textBox5.TextChanged += dodawanie;
            textBox6.TextChanged += dodawanie;
            textBox7.TextChanged += dodawanie;
            textBox8.TextChanged += dodawanie;
            textBox9.TextChanged += dodawanie;
            textBox10.TextChanged += dodawanie;
            textBox11.TextChanged += dodawanie;
            textBox12.TextChanged += dodawanie;
            textBox13.TextChanged += dodawanie;
            textBox14.TextChanged += dodawanie;

            // domysla wartosc
            podstawowe();
        }

        private void LoadData()
        {
            using (MySqlConnection connection = new MySqlConnection(conn.ConnectionString))
            {
                string query = "SELECT Tytul, Rezyser, Ocena, Data, Dlugosc FROM `filmy`";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void podstawowe()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "0.00";
        }

        private void dodawanie(object sender, EventArgs e)
        {
            try
            {
                double sum = 0;

                sum += kwoty(textBox1) * 15.00;
                sum += kwoty(textBox2) * 25.00;
                sum += kwoty(textBox3) * 20.00;
                sum += kwoty(textBox4) * 30.00;
                sum += kwoty(textBox5) * 20.00;
                sum += kwoty(textBox6) * 20.00;
                sum += kwoty(textBox7) * 10.00;
                sum += kwoty(textBox8) * 20.00;
                sum += kwoty(textBox9) * 10.00;
                sum += kwoty(textBox10) * 20.00;
                sum += kwoty(textBox11) * 5.00;
                sum += kwoty(textBox12) * 10.00;
                sum += kwoty(textBox13) * 20.00;
                sum += kwoty(textBox14) * 25.00;

                
                textBox15.Text = sum.ToString("F2"); // Wyświetlanie sumy do 2 po przecinku.
            }
            catch (FormatException)
            {
                textBox15.Text = "0.00"; 
            }
        }

        private double kwoty(TextBox textBox) // Dzięki temu gdy wpisze się litere np to pomija to pole i dodaje dalej. Sprawdza poprawność pisowni.
        {
            double value = 0;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                double.TryParse(textBox.Text, out value);
            }
            return value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void label8_Click(object sender, EventArgs e) { }

        private void label15_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label28_Click(object sender, EventArgs e) { }

        private void label29_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void textBox4_TextChanged(object sender, EventArgs e) { }

        private void textBox5_TextChanged(object sender, EventArgs e) { }

        private void textBox6_TextChanged(object sender, EventArgs e) { }

        private void textBox7_TextChanged(object sender, EventArgs e) { }

        private void textBox8_TextChanged(object sender, EventArgs e) { }

        private void textBox9_TextChanged(object sender, EventArgs e) { }

        private void textBox10_TextChanged(object sender, EventArgs e) { }

        private void textBox11_TextChanged(object sender, EventArgs e) { }

        private void textBox12_TextChanged(object sender, EventArgs e) { }

        private void textBox13_TextChanged(object sender, EventArgs e) { }

        private void textBox14_TextChanged(object sender, EventArgs e) { }

        private void textBox15_TextChanged(object sender, EventArgs e) { }
    }
}