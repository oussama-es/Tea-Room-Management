using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Serveur
    {
        int idSeveur;
        string nom;
        string prenom;

        public Serveur()
        {

        }
        public Serveur(int idSeveur, string nom, string prenom)
        {
            IdSeveur = idSeveur;
            Nom = nom;
            Prenom = prenom;
        }

        public int IdSeveur { get => idSeveur; set => idSeveur = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public override string ToString()
        {
            return idSeveur + "|" + nom + "|" + prenom;
        }
    }
}
