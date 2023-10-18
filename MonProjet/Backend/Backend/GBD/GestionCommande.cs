using Backend.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Backend.Models.Commande;

namespace Backend.GBD
{
    public class GestionCommande
    {
        public bool InsertCommande(Commande commande)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False"; // Remplacez "votre_connection_string" par votre chaîne de connexion réelle

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                   
                    string checkQuery = "SELECT IdServeur FROM Serveurs WHERE IdServeur = @IdServeur";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@IdServeur", commande.IdServeur);

                        connection.Open();
                        object result = checkCommand.ExecuteScalar();

                        if (result != null)
                        {
                            string insertQuery = "INSERT INTO Commandes (IdCommande,dateCom, heureCom, IdServeur) VALUES (@IdCommande,@dateCom, @heureCom, @IdServeur)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@IdCommande", commande.Id);
                                insertCommand.Parameters.AddWithValue("@dateCom", commande.Date);
                                insertCommand.Parameters.AddWithValue("@heureCom", commande.Heure);
                                insertCommand.Parameters.AddWithValue("@IdServeur", commande.IdServeur);

                                int rowsAffected = insertCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Une exception s'est produite lors de l'exécution de la fonction InsertCommande : " + ex.Message);
                    return false;
                }
            }
        }



        public bool UpdateCommande(Commande commande)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False"; // Remplacez "votre_connection_string" par votre chaîne de connexion réelle

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Vérifier si l'ID du serveur existe
                string checkQuery = "SELECT IdServeur FROM Serveurs WHERE IdServeur = @IdServeur";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@IdServeur", commande.IdServeur);

                    connection.Open();
                    object result = checkCommand.ExecuteScalar();

                    if (result != null)
                    {
                        string updateQuery = "UPDATE Commandes SET dateCom = @dateCom, heureCom = @heureCom, IdServeur = @IdServeur WHERE IdCommande = @idCommande";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@dateCom", commande.Date);
                            updateCommand.Parameters.AddWithValue("@heureCom", commande.Heure);
                            updateCommand.Parameters.AddWithValue("@IdServeur", commande.IdServeur);
                            updateCommand.Parameters.AddWithValue("@idCommande", commande.Id);

                            int rowsAffected = updateCommand.ExecuteNonQuery();
                            return (rowsAffected > 0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("L'ID du serveur n'existe pas dans la table Serveurs.");
                    }
                }
            }
            return false; 
        }

        public bool DeleteCommande(int idCommande)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Commandes WHERE IdCommande = @idCommande";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCommande", idCommande);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


        public List<Commande> RechercherCommandes(int Id)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Commande> commandes = new List<Commande>();
                string query = "SELECT * FROM Commandes WHERE idCommande = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Commande commande = new Commande();
                        commande.Id = reader.GetInt32(0);
                        commande.Date = reader.GetDateTime(1);
                        commande.Heure = reader.GetTimeSpan(2);
                        commande.IdServeur = reader.GetInt32(3);
                        commandes.Add(commande);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de la recherche des commandes : " + ex.Message);
                }

                return commandes;
            }
        }


        public List<Commande> SelectCommandes()
        {
            List<Commande> commandes = new List<Commande>();
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdCommande, dateCom, heureCom, IdServeur FROM Commandes";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Commande commande = new Commande();
                            commande.Id = reader.GetInt32(0);
                            commande.Date = reader.GetDateTime(1);
                            commande.Heure = reader.GetTimeSpan(2);
                            commande.IdServeur = reader.GetInt32(3);

                            commandes.Add(commande);
                        }
                    }
                }
            }

            return commandes;
        }

        public List<Dictionary<string, double>> ListerBilanCommandesServeurs(DateTime date)
        {

            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False";

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                connection.Open();

               
                SqlCommand command = new SqlCommand(
                    "SELECT Serveurs.nom, SUM(Boissons.prix * BoissonsCommandées.quantitecommandee) as total_ventes " +
                    "FROM Serveurs " +
                    "JOIN Commandes ON Serveurs.IdServeur = Commandes.IdServeur " +
                    "JOIN BoissonsCommandées ON Commandes.IdCommande = BoissonsCommandées.IdCommande " +
                    "JOIN Boissons ON BoissonsCommandées.IdBoisson = Boissons.IdBoisson " +
                    "WHERE Commandes.dateCom = @date " +
                    "GROUP BY Serveurs.nom",
                    connection);

             
                command.Parameters.AddWithValue("@date", date);

              
                using (SqlDataReader reader = command.ExecuteReader())
                {
                   
                    List<Dictionary<string, double>> bilans = new List<Dictionary<string, double>>();

                    
                    while (reader.Read())
                    {
                        string nomServeur = reader.GetString(0);
                        double totalVentes = reader.GetDouble(1);

                        Dictionary<string, double> bilanServeur = new Dictionary<string, double>();
                        bilanServeur.Add(nomServeur, totalVentes);

                        bilans.Add(bilanServeur);
                    }

                   
                    return bilans;
                }
            }
        }










    }
}
