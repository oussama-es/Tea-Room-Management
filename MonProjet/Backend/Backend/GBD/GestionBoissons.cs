using Backend.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.GBD
{
    public class GestionBoissons : IGestionBoissons
    {
        public bool InsertBoisson(Boissons boisson)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Boissons (IdBoisson,designation, prix, qteStock) VALUES (@IdBoisson,@designation, @prix, @qteStock)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdBoisson", boisson.IdBoisson);
                    command.Parameters.AddWithValue("@designation", boisson.Designation);
                    command.Parameters.AddWithValue("@prix", boisson.Prix);
                    command.Parameters.AddWithValue("@qteStock", boisson.QteStock);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Une erreur s'est produite lors de l'insertion de la boisson : {0}", ex.Message);
                        return false;
                    }
                }
            }
        }


        public List<Boissons> SelectBoissons()
        {
            List<Boissons> boissons = new List<Boissons>();
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdBoisson, designation, prix, qteStock FROM Boissons";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Boissons boisson = new Boissons();
                        {
                            boisson.IdBoisson = reader.GetInt32(0);
                            boisson.Designation = reader.GetString(1);
                            boisson.Prix = Convert.ToSingle(reader.GetDouble(2));

                            boisson.QteStock = reader.GetInt32(3);
                        };
                        boissons.Add(boisson);
                    }

                    reader.Close();
                }
            }

            return boissons;
        }

        public bool UpdateBoisson(Boissons boisson)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Boissons SET designation = @nouvelleDesignation, prix = @nouveauPrix, qteStock = @nouvelleQteStock WHERE IdBoisson = @idBoisson";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nouvelleDesignation", boisson.Designation);
                    command.Parameters.AddWithValue("@nouveauPrix", boisson.Prix);
                    command.Parameters.AddWithValue("@nouvelleQteStock", boisson.QteStock);
                    command.Parameters.AddWithValue("@idBoisson", boisson.IdBoisson);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public List<Boissons> SearchBoissons(string designation, int qteStock)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False";

            List<Boissons> boissons = new List<Boissons>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdBoisson, Designation, Prix, QteStock FROM Boissons WHERE Designation LIKE @designation AND QteStock >= @qteStock";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@designation", "%" + designation + "%");
                    command.Parameters.AddWithValue("@qteStock", qteStock);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Boissons boisson = new Boissons();
                        {
                            boisson.IdBoisson = reader.GetInt32(0);

                            boisson.Designation = reader.GetString(1);
                            boisson.Prix = Convert.ToSingle(reader.GetDouble(2));

                            boisson.QteStock = reader.GetInt32(3);
                        };
                        boissons.Add(boisson);
                    }

                    reader.Close();
                }
            }

            return boissons;
        }
        public bool DeleteBoisson(int idBoisson)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=salon_de_thé;Integrated Security=True;Pooling=False"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Boissons WHERE IdBoisson = @idBoisson";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idBoisson", idBoisson);

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






    }
}
