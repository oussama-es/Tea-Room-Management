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
    public partial class FormModifierCommande : Form
    {
        public FormModifierCommande()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Commande c = new Commande(int.Parse(textBox1.Text), dateTimePicker1.Value, dateTimePicker2.Value.TimeOfDay, int.Parse(textBox4.Text));

            bool ok = Program.gestionCommande.UpdateCommande(c);
            if (ok)
            {
                MessageBox.Show("L'operation a réussi !");
            }
            else
            {
                MessageBox.Show("L'operation a échoué !");
            }

        }

        private void FormModifierCommande_KeyPress(object sender, KeyPressEventArgs e)
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
