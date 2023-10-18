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
    public partial class ListerBilan : Form
    {
        public ListerBilan(List<Dictionary<string, double>> bilans)
        {
            InitializeComponent();

           
            DataTable dataTable = new DataTable();

            // Ajouter les colonnes à la table de données
            dataTable.Columns.Add("Nom serveur");
            dataTable.Columns.Add("Total ventes");

            // Ajouter chaque bilan de commande pour chaque serveur à la table de données
            foreach (Dictionary<string, double> bilanServeur in bilans)
            {
                foreach (KeyValuePair<string, double> kvp in bilanServeur)
                {
                    string nomServeur = kvp.Key;
                    double totalVentes = kvp.Value;

                    DataRow row = dataTable.NewRow();
                    row["Nom serveur"] = nomServeur;
                    row["Total ventes"] = totalVentes;

                    dataTable.Rows.Add(row);
                }
            }

            // Lier la source de données à la DataGridView
            dataGridView1.DataSource = dataTable;




        }

        private void ListerBilan_Load(object sender, EventArgs e)
        {

        }
    }
}
