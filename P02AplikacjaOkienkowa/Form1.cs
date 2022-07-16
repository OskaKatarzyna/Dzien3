using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02AplikacjaOkienkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmPowitanie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ala ma kota");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btmZamkniecie_Click(object sender, EventArgs e)
        {

        }

        private void btmWyswietlPowitanie_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text = "hej";
        }
    }
}
