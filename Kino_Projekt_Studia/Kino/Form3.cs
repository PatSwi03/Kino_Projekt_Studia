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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Kino
{
    public partial class Form3 : Form 
    {
        private List<Movie> movies = new List<Movie>();
        MySqlConnection conn = new MySqlConnection(@"SERVER=localhost; DATABASE=Kino; UID=root; PASSWORD=''");

        public Form3()
        {
            InitializeComponent();
            LoadData();
            // Dodajemy zdarzenia TextChanged dla wszystkich textBoxów
            textBox1.TextChanged += UpdateSum;
            textBox2.TextChanged += UpdateSum;
            textBox3.TextChanged += UpdateSum;
            textBox4.TextChanged += UpdateSum;
            textBox5.TextChanged += UpdateSum;
            textBox6.TextChanged += UpdateSum;
            textBox7.TextChanged += UpdateSum;
            textBox8.TextChanged += UpdateSum;
            textBox9.TextChanged += UpdateSum;
            textBox10.TextChanged += UpdateSum;
            textBox11.TextChanged += UpdateSum;
            textBox12.TextChanged += UpdateSum;
            textBox13.TextChanged += UpdateSum;
            textBox14.TextChanged += UpdateSum;

            // Ustawiamy domyślne wartości
            SetDefaultValues();
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

        private void SetDefaultValues()
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0.00";
        }

        private void UpdateSum(object sender, EventArgs e)
        {
            try
            {
                // Pobieranie wartości z TextBoxów i mnożenie przez odpowiednie ceny
                double sum = 0;
                sum += Convert.ToDouble(textBox1.Text) * 15.00;
                sum += Convert.ToDouble(textBox2.Text) * 25.00;
                sum += Convert.ToDouble(textBox3.Text) * 20.00;
                sum += Convert.ToDouble(textBox4.Text) * 30.00;
                sum += Convert.ToDouble(textBox5.Text) * 20.00;
                sum += Convert.ToDouble(textBox6.Text) * 20.00;
                sum += Convert.ToDouble(textBox7.Text) * 10.00;
                sum += Convert.ToDouble(textBox8.Text) * 20.00;
                sum += Convert.ToDouble(textBox9.Text) * 10.00;
                sum += Convert.ToDouble(textBox10.Text) * 20.00;
                sum += Convert.ToDouble(textBox11.Text) * 5.00;
                sum += Convert.ToDouble(textBox12.Text) * 10.00;
                sum += Convert.ToDouble(textBox13.Text) * 20.00;
                sum += Convert.ToDouble(textBox14.Text) * 25.00;

                // Wyświetlanie sumy w textBox15
                textBox15.Text = sum.ToString("F2");
            }
            catch (FormatException)
            {
                // Ignorowanie błędów konwersji, jeśli tekst nie jest liczbą
                textBox15.Text = "0.00";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
