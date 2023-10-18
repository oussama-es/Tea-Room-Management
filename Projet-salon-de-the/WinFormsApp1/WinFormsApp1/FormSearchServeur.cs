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
    public partial class FormSearchServeur : Form
    {
        public FormSearchServeur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Serveur> list = new List<Serveur>();
            list = Program.gestionServeur.SearchServeurs(textBox1.Text, textBox2.Text);
            FormDataGridSearch f = new FormDataGridSearch(list);
            f.ShowDialog();
        }

        private void FormSearchServeur_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
