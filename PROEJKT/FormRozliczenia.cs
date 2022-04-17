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
    public partial class FormRozliczenia : Form
        

    {
        
        public FormRozliczenia()
        {
            InitializeComponent();
           
            
            

        }

        private void FormRozliczenia_Load(object sender, EventArgs e)
        {
            foreach (Mechanik mechanik in Mechanik.ListaMechaników)
            {
                comboRozliczenia.Items.Add(mechanik.PelnaNazwa);
            }
            
        }

        private void comboRozliczenia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
        



        private void rozlicz_click(object sender, EventArgs e)
        {
            
            WyświetlTabelkeRozliczeń();
            
        }
        private void WyświetlTabelkeRozliczeń()
        {
            dataGridView1.Rows.Clear();

            foreach (Naprawa nap in Naprawa.ListaNapraw)
            {
                if (Convert.ToString(comboRozliczenia.SelectedItem) == nap.Mechanicy.PelnaNazwa)
                {

                    dataGridView1.Rows.Add(nap.NrRej, nap.DataNaprawy.ToShortDateString(), nap.KosztCzesci, nap.CzasPracy, nap.Suma);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
