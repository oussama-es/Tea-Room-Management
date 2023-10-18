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
    public partial class FormUpdateBoissons : Form
    {
        public FormUpdateBoissons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boissons b = new Boissons(int.Parse(textBox1.Text), textBox4.Text, float.Parse(textBox2.Text), int.Parse(textBox3.Text));

            bool ok = Program.gestionBoisson.UpdateBoisson(b);
            if (ok)
            {
                MessageBox.Show("L'operation a réussi !");
            }
            else
            {
                MessageBox.Show("L'operation a échoué !");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Empêche l'entrée du caractère
            }
            // Vérifie si le caractère est un point ou une virgule et si le TextBox ne contient pas déjà une virgule
            else if ((e.KeyChar == '.') && textBox2.Text.Contains('.'))
            {
                e.Handled = true; // Empêche l'entrée du caractère
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Rejeter le caractère invalide
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie si le caractère tapé n'est pas un chiffre, un point, ou une virgule
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Empêche l'entrée du caractère
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
