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
    public partial class FormListerCommande : Form
    {
        public FormListerCommande()
        {
            InitializeComponent();
        }

        private void FormListerCommande_Load(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = Program.gestionCommande.SelectCommandes();
            dataGridView1.DataSource = source;


        }
    }
}
