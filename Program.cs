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

            void ex1() //classe Employe.cs
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

            void ex2() //classe Produit.css
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

            void ex3() //Class Employe2.cs
            {
                int rep, selec;
                string prenom, nom;
                double salaire;

                Console.WriteLine("Menu ---------------");
                Console.WriteLine("1. Ajouter employé");
                Console.WriteLine("2. Supprimer employé");
                Console.WriteLine("3. Afficher employé");
                Console.WriteLine("4. Afficher employés");
                Console.WriteLine("5. Afficher salaire moyen");
                Console.WriteLine("6. Afficher salaire max");
                Console.WriteLine("7. Afficher salaire min");
                rep = int.Parse(Console.ReadLine());

                List<Employe2> lesEmployes2 = new List<Employe2>();
                lesEmployes2.Add(new Employe2("Presnel", "Kimpembe", 50000));
                //lesEmployes2.Add(new Employe2("Mbappé", "Killian", 200000));
                //lesEmployes2.Add(new Employe2("da Silva Santos Júnior", "Neymar", 200000));

                do
                {
                    Console.WriteLine("Menu ---------------");
                    Console.WriteLine("1. Ajouter employé");
                    Console.WriteLine("2. Supprimer employé");
                    Console.WriteLine("3. Afficher employé");
                    Console.WriteLine("4. Afficher employés");
                    Console.WriteLine("5. Afficher salaire moyen");
                    Console.WriteLine("6. Afficher salaire max");
                    Console.WriteLine("7. Afficher salaire min");
                    rep = int.Parse(Console.ReadLine());

                    switch (rep)
                    {
                        case 1:
                            Console.WriteLine("Ajout d'un employé ------");
                            Console.WriteLine("Nom de l'employé :");
                            prenom = Console.ReadLine();
                            Console.WriteLine("Prénom de l'employé :");
                            nom = Console.ReadLine();
                            Console.WriteLine("Salaire de l'employé :");
                            salaire = double.Parse(Console.ReadLine());
                            lesEmployes2.Add(new Employe2(prenom, nom, salaire));
                            break;
                        case 2:
                            Console.WriteLine("Suppression d'un employé ------");
                            for (int i = 0; i < lesEmployes2.Count(); i++)
                            {
                                Console.WriteLine(i + ". " + lesEmployes2[i].getNom() + " " + lesEmployes2[i].getPrenom());
                            }
                            selec = int.Parse(Console.ReadLine());
                            Console.WriteLine("Suppression... (" + lesEmployes2[selec].getNom() + " " + lesEmployes2[selec].getPrenom() + ")");
                            lesEmployes2.RemoveAt(selec);
                            Console.WriteLine("Supprimé.");
                            break;
                        case 3:
                            Console.WriteLine("Affichage d'un employé ------");
                            for (int i = 0; i < lesEmployes2.Count(); i++)
                            {
                                Console.WriteLine(i + ". " + lesEmployes2[i].getNom() + " " + lesEmployes2[i].getPrenom());
                            }
                            selec = int.Parse(Console.ReadLine());
                            Console.WriteLine("Profil employé n°" + selec);
                            Console.WriteLine("Nom : " + lesEmployes2[selec].getNom());
                            Console.WriteLine("Prénom : " + lesEmployes2[selec].getPrenom());
                            Console.WriteLine("Salaire : " + lesEmployes2[selec].getSalaire() + " euros");
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.WriteLine("Affichage des employés ------");
                            for (int i = 0; i < lesEmployes2.Count(); i++)
                            {
                                Console.WriteLine("n°" + i + " " + lesEmployes2[i].getNom() + " " + lesEmployes2[i].getPrenom());
                            }
                            break;
                    }
                } while (rep > 0);
               
            }

            //ex1();
            //ex2();
            ex3();

            Console.ReadKey();
        }
    }
}
