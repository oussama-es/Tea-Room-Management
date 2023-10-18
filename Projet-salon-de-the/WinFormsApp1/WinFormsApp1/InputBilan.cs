using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class InputBilan : Form
    {
        public InputBilan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Obtenez la date à partir d'un DateTimePicker
            DateTime date = dateTimePicker1.Value;

            // Obtenez la date sans l'heure
            DateTime dateSansHeure = date.Date;


            List<Dictionary<string, double>> liste = Program.gestionCommande.ListerBilanCommandesServeurs(date.Date);
            ListerBilan f = new ListerBilan(liste);

            f.ShowDialog();
        }

        private void InputBilan_Load(object sender, EventArgs e)
        {

        }
    }
}
