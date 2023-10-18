using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void createTables(SqlConnection connection)
        {

            // create the Serveurs table
            string createServeursTable = "CREATE TABLE Serveurs (IdServeur INT PRIMARY KEY, nom VARCHAR(50), prenom VARCHAR(50))";
            SqlCommand createServeursCommand = new SqlCommand(createServeursTable, connection);
            createServeursCommand.ExecuteNonQuery();

            // create the Boissons table
            string createBoissonsTable = "CREATE TABLE Boissons (IdBoisson INT PRIMARY KEY, designation VARCHAR(50), prix DECIMAL(10,2), qteStock INT)";
            SqlCommand createBoissonsCommand = new SqlCommand(createBoissonsTable, connection);
            createBoissonsCommand.ExecuteNonQuery();

            // create the Commandes table
            string createCommandesTable = "CREATE TABLE Commandes (IdCommande INT PRIMARY KEY, dateCom DATE, heureCom TIME, IdServeur INT, FOREIGN KEY (IdServeur) REFERENCES Serveurs(IdServeur))";
            SqlCommand createCommandesCommand = new SqlCommand(createCommandesTable, connection);
            createCommandesCommand.ExecuteNonQuery();

            // create the BoissonsCommandees table
            string createBoissonsCommandeesTable = "CREATE TABLE BoissonsCommandees (IdBoisson INT, IdCommande INT, qteCommandee INT, PRIMARY KEY (IdBoisson, IdCommande), FOREIGN KEY (IdBoisson) REFERENCES Boissons(IdBoisson), FOREIGN KEY (IdCommande) REFERENCES Commandes(IdCommande))";
            SqlCommand createBoissonsCommandeesCommand = new SqlCommand(createBoissonsCommandeesTable, connection);
            createBoissonsCommandeesCommand.ExecuteNonQuery();

            // close the connection
            connection.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create a connection to the database

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False";
            connection.Open();

            // open the connection

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterServeur f1 = new FormAjouterServeur();
            f1.ShowDialog();
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListerServeur f = new FormListerServeur();
            f.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupprimerServeur f = new FormSupprimerServeur();
            f.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateServeur f = new FormUpdateServeur();
            f.ShowDialog();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchServeur f = new FormSearchServeur();
            f.ShowDialog();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAjouterBoissons f = new FormAjouterBoissons();
            f.ShowDialog();
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormUpdateBoissons f = new FormUpdateBoissons();
            f.ShowDialog();
        }

        private void listerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSelectBoissons f = new FormSelectBoissons();
            f.ShowDialog();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSupprimerBoissons f = new FormSupprimerBoissons();
            f.ShowDialog();
        }

        private void rechercherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRechercherBoissons f = new FormRechercherBoissons();
            f.ShowDialog();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormAjouterCommande f = new FormAjouterCommande();
            f.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormModifierCommande f = new FormModifierCommande();
            f.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormListerCommande f = new FormListerCommande();
            f.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormRechercherCommande f = new FormRechercherCommande();
            f.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormSupprimerCommande f = new FormSupprimerCommande();
            f.ShowDialog();
        }

        private void listerBilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBilan f = new InputBilan();
            f.ShowDialog();
        }

        private void quitterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}