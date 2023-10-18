using Backend;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class FormListerServeur : Form
    {
        public FormListerServeur()
        {
            InitializeComponent();
        }
        private void FormListerServeur_Load(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = Program.gestionServeur.select();
            dataGridView1.DataSource = source;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
