using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Type_List
{
    class Program
    {
        static void Main(string[] args)
        {

            Employe e1 = new Employe("Poivre Romain");
            Employe e2 = new Employe("Safran Pauline");
            Employe e3 = new Employe("Canelle Coline");
            Employe e4 = new Employe("Coriandre Joël");

            List<string> lesEmployes = new List<string>();
            lesEmployes.Add(e1.getNom());
            lesEmployes.Add(e2.getNom());
            lesEmployes.Add(e3.getNom());
            lesEmployes.Add(e4.getNom());


            Console.WriteLine("Liste initiale des employés");
            for (int i = 0; i < lesEmployes.Count(); i++)
            {
                Console.WriteLine("rang " + i + " nom de l'employé : " + lesEmployes[i]);
            }

            lesEmployes.Insert(0, );

            Console.WriteLine("Affichage de la liste après une insertion");


           



            Console.ReadKey();
        }
    }
}
