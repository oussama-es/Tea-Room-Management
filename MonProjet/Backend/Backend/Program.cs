using Backend.GBD;
using System.Data.SqlClient;

namespace Backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            GestionCommande gs=new GestionCommande();
            DateTime date = new DateTime(2023, 5, 12);



            List<Dictionary<string, double>> bilans = gs.ListerBilanCommandesServeurs(date);

            foreach (Dictionary<string, double> bilan in bilans)
            {
                foreach (KeyValuePair<string, double> kvp in bilan)
                {
                    Console.WriteLine("Serveur: {0}, Total des ventes: {1:C}", kvp.Key, kvp.Value);
                }
            }

            Console.ReadLine(); // pour évi

        }
    }
}