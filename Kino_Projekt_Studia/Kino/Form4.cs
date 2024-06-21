using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Kino
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTransactionProcess();
        }

        private void StartTransactionProcess()
        {
            
            while (true)
            {
                
                var result = MessageBox.Show("Czy klient przyłożył kartę?", "Pytanie", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Matrixdokarty();  // Symuluje efekt "Matrix"

                    
                    var paymentResult = MessageBox.Show("Czy płatność przebiegła pomyślnie?", "Pytanie", MessageBoxButtons.YesNo);

                    if (paymentResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Transakcja zrealizowana pomyślnie", "Informacja");
                        Form2 form2 = new Form2();
                        form2.Show();
                        Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Proszę ponowić próbę", "Informacja");
                        Form4 form4 = new Form4();
                        form4.Show();
                        Hide();
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Proszę ponowić próbę", "Informacja");
                    Form4 form4 = new Form4();
                    form4.Show();
                    Hide();
                    break;
                }
            }
        }

        private void Matrixdokarty()
        {
            Form matrix = new Form(); 
            matrix.StartPosition = FormStartPosition.CenterScreen;  // Pojawia się na środku ekranu dzięki temu
            matrix.Size = new Size(300, 300); //Rozmiar okna

            TextBox wiadomosc = new TextBox();
            wiadomosc.Multiline = true;  // Ustawia TextBox jako wieloliniowy
            wiadomosc.Dock = DockStyle.Fill;  // Ustawia TextBox na wypełnienie całego formularza
            wiadomosc.BackColor = Color.Black;
            wiadomosc.ForeColor = Color.Lime;
            wiadomosc.Font = new Font("Consolas", 10);  // Ustawia czcionkę na "Consolas" rozmiar 10
            matrix.Controls.Add(wiadomosc);  // Dodaje TextBox do formularza
            matrix.Show();  

            var chars = "IJKLMNABCDEFGHIJ45PQRSTUKLMSTUKLMSTUKLKSTNO012GHI345PQRSTUVWXYZ012GHI3456789"; //Teskt do wyświetlenia gdy leci "matrix"
            var sekundnik = DateTime.Now;  // Zmienna odpowiadająca skryptowi który ma uruchomić "matrix" na 1 sekundę. 

            
            while ((DateTime.Now - sekundnik).TotalSeconds < 1) //Pętla od "matrixa"
            {
                wiadomosc.AppendText(chars + Environment.NewLine);  // Dodaje spam znaczków
                wiadomosc.SelectionStart = wiadomosc.Text.Length;  // przesuwa kursor na koniec
                wiadomosc.ScrollToCaret();  // dzięki temu tekst leci w dół, a nie zostaje w jednym miejsu (scrolluje text w dół)
                Thread.Sleep(100);  // Wstrzymuje wartości na 100 milisekund (bez tego tekst nie leci z góry do dołu)
            }

            matrix.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }
    }
}
