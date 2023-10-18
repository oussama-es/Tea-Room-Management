using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Boissons
    {
        int idBoisson;
        string designation;
        float prix;
        int qteStock;

        public Boissons()
        {

        }

        public Boissons(int idBoisson, string designation, float prix, int qteStock)
        {
            IdBoisson = idBoisson;
            Designation = designation;
            Prix = prix;
            QteStock = qteStock;
        }
        public Boissons( string designation, float prix, int qteStock)
        {
       
            Designation = designation;
            Prix = prix;
            QteStock = qteStock;
        }

        public int IdBoisson { get => idBoisson; set => idBoisson = value; }
        public string Designation { get => designation; set => designation = value; }
        public float Prix { get => prix; set => prix = value; }
        public int QteStock { get => qteStock; set => qteStock = value; }

        public override string ToString()
        {
            return IdBoisson + "|" + designation + "|" + Prix + "|" + qteStock;
        }

    }
}
