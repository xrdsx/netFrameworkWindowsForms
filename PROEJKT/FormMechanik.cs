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
    public partial class FormMechanik : Form
    {
  public FormMechanik()
        {
            InitializeComponent();
        }
        void TabelkaNapraw()
        {
            dataGridView1.Rows.Clear();

            // NrRej / Data / Mechanik / Koszt czesci / Koszt pracy / Suma
            
            
            foreach (Naprawa n in Naprawa.ListaNapraw)
                dataGridView1.Rows.Add(n.NrRej, n.DataNaprawy.ToShortDateString(), n.Mechanicy.PelnaNazwa,n.KosztCzesci, n.CzasPracy, n.Suma);
                    
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Naprawa nowa_naprawa = new Naprawa();

            FormAdd form = new FormAdd(nowa_naprawa);
            form.ShowDialog();

            Naprawa.ListaNapraw.Add(nowa_naprawa);
            TabelkaNapraw();
        }

        private void FormMechanik_Load(object sender, EventArgs e)
        {
            
            
           
        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
