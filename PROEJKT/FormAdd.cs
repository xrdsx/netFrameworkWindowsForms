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
    
    public partial class FormAdd : Form
    {
        Naprawa naprawy;

        public FormAdd(Naprawa naprawy)
        {
            InitializeComponent();
            this.naprawy = naprawy;

            comboBox1.DataSource = Mechanik.ListaMechaników;
            //comboBox1.DisplayMember = "PelnaNazwa";
            comboBox1.DisplayMember = nameof(Mechanik.PelnaNazwa); 
        }


        public void FormAdd_Load(object sender, EventArgs e)
        {
            textBox1.Text = naprawy.NrRej;
            dateTimePicker1.Value = naprawy.DataNaprawy;
            numericUpDown2.Value = naprawy.KosztCzesci;
            numericUpDown3.Value = naprawy.CzasPracy;
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            DialogResult = DialogResult.Cancel;
            Close();
        }

        decimal Robocizna(Naprawa naprawy)
        {
            decimal koszt = naprawy.KosztCzesci + (naprawy.CzasPracy * Convert.ToDecimal(textBox3.Text));
            return koszt;
        }
            
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mechanik mechanicy = comboBox1.SelectedItem as Mechanik;
            textBox3.Text = Convert.ToString(mechanicy.Stawka);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrzyciskDodaj_click(object sender, EventArgs e)
        {
            naprawy.NrRej = textBox1.Text;
            naprawy.DataNaprawy = dateTimePicker1.Value;
            naprawy.Mechanicy = (Mechanik)comboBox1.SelectedItem;
            naprawy.KosztCzesci = numericUpDown2.Value;
            naprawy.CzasPracy = numericUpDown3.Value;

            textBox2.Text = "" + Robocizna(naprawy);
            naprawy.Suma = Robocizna(naprawy);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
