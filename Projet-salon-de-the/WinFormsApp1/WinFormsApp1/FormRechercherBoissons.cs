using Backend.Models;
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
    public partial class FormRechercherBoissons : Form
    {
        public FormRechercherBoissons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Boissons> list = new List<Boissons>();
            list = Program.gestionBoisson.SearchBoissons(textBox1.Text, int.Parse(textBox2.Text));
            FormDataGridSearchBoissons f = new FormDataGridSearchBoissons(list);
            f.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie si le caractère tapé n'est pas un chiffre, un point, ou une virgule
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Empêche l'entrée du caractère
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Rejeter le caractère invalide
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
