using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.GBD
{
    public interface IGestionCommande
    {
        public bool InsertCommande(Commande commande);
        public bool UpdateCommande(Commande commande);

        public bool DeleteCommande(int idCommande);
        public List<Commande> RechercherCommandes(int Id);

        public List<Commande> SelectCommandes();
        public List<Dictionary<string, double>> ListerBilanCommandesServeurs(DateTime date);

    }
}
