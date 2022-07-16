using P03AplikacjaKalkulator.Exceptions;
using P03AplikacjaKalkulator.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03AplikacjaKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm1_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text = txtWyswietlacz.Text + "1";
        }

        private void btm2_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text = txtWyswietlacz.Text + "2" ;
        }

        private void btm3_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "3";
        }

        private void btm7_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "7";
        }

        private void btm8_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "8";
        }

        private void btm9_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "9";
        }

        private void btm4_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "4";
        }

        private void btm5_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "5";
        }

        private void btm6_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "6";
        }

        private void btm0_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "0";
        }

        private void btmDodaj_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "+";
        }

        private void btmOdejmij_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "-";
        }

        private void btmPrzemnoz_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "*";
        }

        private void btmPodziel_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "/";
        }

        private void btmRownaSie_Click(object sender, EventArgs e)
        {
            string rownanie = txtWyswietlacz.Text;
            //File.AppendAllText("historia.txt",rownanie+"\n");
            //File.AppendAllText("historia.txt", rownanie + Environment.NewLine);
            try 
            {
                Kalkulator k = new Kalkulator();
                string wynik = Convert.ToString(k.WykonajDzialanie(rownanie));
                txtWyswietlacz.Text = wynik;
                //File.AppendAllText("historia.txt", Environment.NewLine+ rownanie +"="+ wynik);
                File.AppendAllText("historia.txt",$"{ Environment.NewLine} { rownanie} = {wynik}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Niepoprawne dane wejściowe.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Próba dzielenia przez zero.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Zły operator.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Nieznany błąd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmCzysc_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text = "";
        }
    }
}
