using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektWarsztatSamochodowy
{
    public partial class FormLogowanie : Form
    {
        public FormLogowanie()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void mechanik()
        {
            FormMechanik form = new FormMechanik();
            form.ShowDialog();
        }

        void rozliczenia()
        {
            FormRozliczenia form = new FormRozliczenia();
            form.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            mechanik();
        }


        private void zamknij_click(object sender, EventArgs e)
        {
            Close();
        }

        private void rozliczenia_click(object sender, EventArgs e)
        {
            rozliczenia();
        }

        private void FormLogowanie_Load(object sender, EventArgs e)
        {
            Mechanik.ListaMechaników.Add(new Mechanik() { Imie = "Maciek", Nazwisko = "Cebula", RokRozpoczecia = 2007, Stawka = 65 });
            Mechanik.ListaMechaników.Add(new Mechanik() { Imie = "Janek", Nazwisko = "Rzepa", RokRozpoczecia = 2010, Stawka = 50 });
            Mechanik.ListaMechaników.Add(new Mechanik() { Imie = "Piotrek", Nazwisko = "Rzodkiewa", RokRozpoczecia = 2015, Stawka = 85 });
        }
    }
}
