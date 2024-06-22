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
        private MySqlConnection conn = new MySqlConnection(@"SERVER=localhost; DATABASE=Kino; UID=root; PASSWORD=''");

        public Form3()
        {
            InitializeComponent();
            InicjalizujObslugeZdarzen();
            WczytajDane();
            UstawDomyslneWartosci();
        }
        public class Movie
        {
            public string Tytul { get; set; }
            public string Rezyser { get; set; }
            public double Ocena { get; set; }
            public DateTime Data { get; set; }
            public int Dlugosc { get; set; }
        }
        private void InicjalizujObslugeZdarzen()
        {
            // Użyj jednego obsługiwacza zdarzeń dla zmiany tekstu w polach tekstowych
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.TextChanged += DodajDoSumy;
                }
            }
        }

        private void WczytajDane()
        {
            using (MySqlConnection connection = new MySqlConnection(conn.ConnectionString))
            {
                string query = "SELECT Tytul, Rezyser, Ocena, Data, Dlugosc FROM `filmy`";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    movies.Add(new Movie
                    {
                        Tytul = row["Tytul"].ToString(),
                        Rezyser = row["Rezyser"].ToString(),
                        Ocena = Convert.ToDouble(row["Ocena"]),
                        Data = Convert.ToDateTime(row["Data"]),
                        Dlugosc = Convert.ToInt32(row["Dlugosc"])
                    });
                }

                dataGridView1.DataSource = dataTable;
            }
        }

        private void UstawDomyslneWartosci()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }

            textBox15.Text = "0.00";
        }

        private void DodajDoSumy(object sender, EventArgs e)
        {
            try
            {
                double suma = 0;

                foreach (Control control in Controls)
                {
                    if (control is TextBox textBox)
                    {
                        suma += PobierzKwote(textBox) * PobierzStawkeFilmu(textBox);
                    }
                }

                textBox15.Text = suma.ToString("F2"); // Wyświetlenie sumy z dokładnością do 2 miejsc po przecinku
            }
            catch (FormatException)
            {
                textBox15.Text = "0.00";
            }
        }

        private double PobierzKwote(TextBox textBox)
        {
            double wartosc = 0;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                double.TryParse(textBox.Text, out wartosc);
            }
            return wartosc;
        }

        private double PobierzStawkeFilmu(TextBox textBox)
        {
            // Przykładowa logika pobierania stawki na podstawie nazwy pola textBox lub innych kryteriów
            // Zastąp to Twoją rzeczywistą logiką biznesową
            return 15.00; // Przykładowa stawka; zastąp swoją rzeczywistą logiką
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}