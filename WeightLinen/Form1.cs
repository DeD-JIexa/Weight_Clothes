using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightLinen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region Defolt
            Fytbolka.Text = "0";
            Pybashka.Text = "0";
            PlatieKorotkoe.Text = "0";
            PlatieDlinnoe.Text = "0";
            Noski.Text = "0";
            Kolgotki.Text = "0";
            Prostinia.Text = "0";
            Pododialnik.Text = "0";
            PolotenceMalenkoe.Text = "0";
            PolotenceBolshoe.Text = "0";
            Skatert.Text = "0";
            Navolochka.Text = "0";
            #endregion
        }
        #region Object
        private void Fytbolka_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Pybashka_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlatieKorotkoe_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlatieDlinnoe_TextChanged(object sender, EventArgs e)
        {

        }

        private void Noski_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kolgotki_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prostinia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pododialnik_TextChanged(object sender, EventArgs e)
        {

        }

        private void PolotenceMalenkoe_TextChanged(object sender, EventArgs e)
        {

        }

        private void PolotenceBolshoe_TextChanged(object sender, EventArgs e)
        {

        }

        private void Skatert_TextChanged(object sender, EventArgs e)
        {

        }

        private void Navolochka_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region TextObject
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void FinishText_Click(object sender, EventArgs e)
        {

        }

        private void Srart_Click(object sender, EventArgs e)
        {
            #region ObjectNum

            int fytbolka = Convert.ToInt32(Fytbolka.Text);
            int fyt = fytbolka * 100;

            int pybashka = Convert.ToInt32(Pybashka.Text);
            int pyb = pybashka * 150;
            
            int platiekorotkoe = Convert.ToInt32(PlatieKorotkoe.Text);
            int plak = platiekorotkoe * 50;

            int platiedlinnoe = Convert.ToInt32(PlatieDlinnoe.Text);
            int plad = platiedlinnoe * 100;

            int noski = Convert.ToInt32(Noski.Text);
            int nosk = noski * 10;
            
            int kolgotki = Convert.ToInt32(Kolgotki.Text);
            int kolg = kolgotki * 30;

            int prostinia = Convert.ToInt32(Prostinia.Text);
            int prost = prostinia * 200;

            int pododialnik = Convert.ToInt32(Pododialnik.Text);
            int podo = pododialnik * 400;

            int polotencemalenkoe = Convert.ToInt32(PolotenceMalenkoe.Text);
            int polom = polotencemalenkoe * 100;

            int polotencebolshoe = Convert.ToInt32(PolotenceBolshoe.Text);
            int polob = polotencebolshoe * 200;
            
            int skatert = Convert.ToInt32(Skatert.Text);
            int skat = skatert * 500;

            int navolochka = Convert.ToInt32(Navolochka.Text);
            int navo = navolochka * 150;
            #endregion

            int rez = fyt + pyb + plak + plad + nosk + kolg + prost + podo + polom + polob + skat + navo;

            FinishText.Text = "Результат: " + rez.ToString() + " гр.";
        }
    }
}
