using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.GBD
{
    public class GestionServeur : IGestionServeurs
    {
        public bool AddServeur(int id, string name, string prenom)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False";
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction("MaTransaction");

            try
            {
                SqlCommand command1 = new SqlCommand();
                command1.Connection = connection;
                command1.Transaction = transaction;
                command1.CommandText = "insert into Serveurs(IdServeur, Nom, Prenom) values(@id, @nom, @prenom)";
                command1.Parameters.AddWithValue("@id", id);
                command1.Parameters.AddWithValue("@nom", name);
                command1.Parameters.AddWithValue("@prenom", prenom);
                command1.ExecuteNonQuery();

                // Validation de la transaction
                transaction.Commit();
                Console.WriteLine("Les données ont été insérées avec succès !");
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                // Annulation de la transaction
                transaction.Rollback();
                return false;
            }
            finally
            {
               
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }


        public bool DeleteServeur(int id)
        {
            bool success = false;
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Serveurs WHERE IdServeur = @IdServeur";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdServeur", id);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            success = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erreur : " + ex.Message);
                    }
                    finally
                    {
                        if (connection != null && connection.State != ConnectionState.Closed)
                        {
                            connection.Close();
                        }
                    }
                }
            }

            return success;
        }





        public List<Serveur> select()
        {

            List<Serveur> serveurs = new List<Serveur>();
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdServeur, nom, prenom FROM Serveurs";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Serveur serveur = new Serveur
                        {
                            IdSeveur = reader.GetInt32(0),
                            Nom = reader.GetString(1),
                            Prenom = reader.GetString(2)
                        };
                        serveurs.Add(serveur);
                    }

                    reader.Close();
                }
            }

            return serveurs;


        }
        public bool UpdateServeur(Serveur serveur)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Serveurs SET nom = @nouveauNom, prenom = @nouveauPrenom WHERE IdServeur = @idServeur";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nouveauNom", serveur.Nom);
                    command.Parameters.AddWithValue("@nouveauPrenom", serveur.Prenom);
                    command.Parameters.AddWithValue("@idServeur", serveur.IdSeveur);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }


        public List<Serveur> SearchServeurs(string nom, string prenom)
        {
            List<Serveur> serveurs = new List<Serveur>();
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdServeur, nom, prenom FROM Serveurs WHERE nom LIKE @nom AND prenom LIKE @prenom";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", "%" + nom + "%");
                    command.Parameters.AddWithValue("@prenom", "%" + prenom + "%");

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Serveur serveur = new Serveur
                        {
                            IdSeveur = reader.GetInt32(0),
                            Nom = reader.GetString(1),
                            Prenom = reader.GetString(2)
                        };
                        serveurs.Add(serveur);
                    }

                    reader.Close();
                }
            }

            return serveurs;
        }



    }
}
