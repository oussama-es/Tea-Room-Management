using Backend.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.GBD
{
    public interface IGestionServeurs
    {
        public bool AddServeur(int id, string name, string prenom);
        public bool DeleteServeur(int id);
        public bool UpdateServeur(Serveur serveur);
        public List<Serveur> select();
        public List<Serveur> SearchServeurs(string nom, string prenom);

    }
}
