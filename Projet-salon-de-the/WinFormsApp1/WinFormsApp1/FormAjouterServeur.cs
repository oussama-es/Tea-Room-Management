using Backend;
using Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormAjouterServeur : Form
    {
        public FormAjouterServeur()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAjouterServeur_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Serveur serveur = new Serveur(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text);
           bool ok= Program.gestionServeur.AddServeur(serveur.IdSeveur, serveur.Nom, serveur.Prenom);
            if (ok)
            {
                MessageBox.Show("L'operation a réussi !");
            }
            else
            {
                MessageBox.Show("L'operation a échoué !");
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Rejeter le caractère invalide
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                // Vérifie si le caractère tapé n'est pas un chiffre, un point, ou une virgule
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true; // Empêche l'entrée du caractère
                }

              
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
