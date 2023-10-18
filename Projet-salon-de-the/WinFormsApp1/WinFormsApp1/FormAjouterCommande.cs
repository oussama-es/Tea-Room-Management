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
    public partial class FormAjouterCommande : Form
    {
        public FormAjouterCommande()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormAjouterCommande_Load(object sender, EventArgs e)
        {
            // Définir le format pour afficher l'heure seulement
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true; // Afficher les flèches pour sélectionner l'heure

            // Définir une heure par défaut
            dateTimePicker2.Value = DateTime.Now.Date.AddHours(12); // Par exemple, 12:00:00 PM

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Commande c = new Commande(int.Parse(textBox1.Text), dateTimePicker1.Value, dateTimePicker2.Value.TimeOfDay, int.Parse(textBox4.Text));
            bool ok = Program.gestionCommande.InsertCommande(c);
            if (ok)
            {
                MessageBox.Show("L'operation a réussi !");
            }
            else
            {
                MessageBox.Show("L'operation a échoué !");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
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
