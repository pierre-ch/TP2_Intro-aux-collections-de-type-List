using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Type_List
{
    class Employe
    {
        private string nom;

        public Employe(string leNom)
        {
            this.nom = leNom;
        }

        public string getNom()
        {
            return this.nom;
        }

        public void setNom(string leNom)
        {
            this.nom = leNom;
        }
    }
}
