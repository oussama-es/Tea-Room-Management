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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class FormRechercherCommande : Form
    {
        public FormRechercherCommande()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Commande> list = new List<Commande>();
            list = Program.gestionCommande.RechercherCommandes(int.Parse(textBox1.Text));
            FormSearchCommandeDataGrid f = new FormSearchCommandeDataGrid(list);
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
