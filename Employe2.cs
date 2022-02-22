using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Type_List
{
    class Employe2
    {
        private string nom, prenom;
        private double salaire;

        public Employe2(string leNom, string lePrenom, double leSalaire)
        {
            this.nom = leNom;
            this.prenom = lePrenom;
            this.salaire = leSalaire;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public double getSalaire()
        {
            return this.salaire;
        }

        public void setNom(string leNom)
        {
            this.nom = leNom;
        }
    }
}
