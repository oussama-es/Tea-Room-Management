using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Commande
    {
        int id;
        DateTime date;
        TimeSpan heure;
        int idServeur;

        public Commande()
        {

        }
        public Commande(int id, DateTime date, TimeSpan heure, int idServeur)
        {
            this.id = id;
            this.date = date;
            this.heure = heure;
            this.idServeur = idServeur;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Heure { get => heure; set => heure = value; }
        public int IdServeur { get => idServeur; set => idServeur = value; }

        public override string ToString()
        {
            return id + "|" + date + "|" + heure + "|" + IdServeur;
        }
    }
}
