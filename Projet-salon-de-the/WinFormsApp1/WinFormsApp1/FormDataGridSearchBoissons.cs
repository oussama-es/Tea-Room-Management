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
    public partial class FormDataGridSearchBoissons : Form
    {
        public FormDataGridSearchBoissons(List<Boissons> boissons)
        {

            InitializeComponent();
            BindingSource source = new BindingSource();
            source.DataSource = boissons;
            dataGridView1.DataSource = source;
        }

        private void FormDataGridSearchBoissons_Load(object sender, EventArgs e)
        {

        }
    }
}
