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
    public partial class FormSelectBoissons : Form
    {
        public FormSelectBoissons()
        {
            InitializeComponent();
        }

        private void FormSelectBoissons_Load(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = Program.gestionBoisson.SelectBoissons();
            dataGridView1.DataSource = source;


        }
    }
}
