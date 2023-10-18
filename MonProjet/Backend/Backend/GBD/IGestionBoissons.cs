using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.GBD
{
    public interface IGestionBoissons
    {
        public bool InsertBoisson(Boissons boisson);
        public List<Boissons> SelectBoissons();
        public bool UpdateBoisson(Boissons boisson);
        public List<Boissons> SearchBoissons(string designation, int qteStock);
        public bool DeleteBoisson(int idBoisson);
    }
}
