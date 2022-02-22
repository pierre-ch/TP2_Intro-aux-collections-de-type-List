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

            void ex1()
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
                Console.WriteLine("");

                lesEmployes.Insert(0, "Du Sel Marine");
                Console.WriteLine("Affichage de la liste après une insertion");
                for (int i = 0; i < lesEmployes.Count(); i++)
                {
                    Console.WriteLine("rang " + i + " nom de l'employé : " + lesEmployes[i]);
                }
                Console.WriteLine("");

                Console.WriteLine("La liste comporte " + lesEmployes.Count() + " élements");
                Console.WriteLine("");

                lesEmployes.Sort();
                Console.WriteLine("Affichage de la liste après tri");
                Console.WriteLine("-------------------------------");
                for (int i = 0; i < lesEmployes.Count(); i++)
                {
                    Console.WriteLine("rang " + i + " nom de l'employé : " + lesEmployes[i]);
                }
            }

            void ex2()
            {
                //Declaration            
                Produit p1, p2, p3;

                //Instanciation : réservation d'un espace mémoire pour un objet
                p1 = new Produit(3010, "Pate de fruits", 30, 10, 100);
                p2 = new Produit(3016, "Caramel au lait", 40, 9, 100);
                p3 = new Produit(4010, "Carambar", 25, 10, 20);

                List<Produit> lesProduits = new List<Produit>();
                lesProduits.Add(new Produit (3010, "Pate de fruits", 30, 10, 100));
                lesProduits.Add(new Produit (3016, "Caramel au lait", 40, 9, 100));
                lesProduits.Add(new Produit(4010, "Carambar", 25, 10, 20));


                //La référence et la désignation des trois objets seront affichées. 
                for (int i = 0; i < lesProduits.Count(); i++)
                {
                    Console.WriteLine("produit " + i + " : " + lesProduits[i].getReference() + " " + lesProduits[i].getDesignation());
                }

                //Changement de désignation
                lesProduits[2].setDesignation("Carambar a la fraise");
                Console.WriteLine("nom du troisième produit : " + lesProduits[2].getDesignation());

            }

            //ex1();
            ex2();

            Console.ReadKey();
        }
    }
}
