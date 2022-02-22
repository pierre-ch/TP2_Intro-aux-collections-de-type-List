using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Type_List
{
    public class Produit
    {
        //propriétés : reference, designation, quantite, puht, stock
        private int reference;
        private string designation;
        private int quantite;
        private double puht;
        private int stock;

        //Constructeur : méthode particuliere appelée à l'aide de l'opérateur new
        //Porte le même nom que la classe
        public Produit(int lareference, string ladesignation, int laquantite, double lepuht, int lestock)
        {
            //this : désigne l'objet courant
            this.reference = lareference;
            this.designation = ladesignation;
            this.quantite = laquantite;
            this.puht = lepuht;
            this.stock = lestock;
        }

        public void setDesignation(string ladesignation)
        //Mutateur : méthode permettant de modifier la valeur d'une propriété
        {
            this.designation = ladesignation;
        }

        public string getDesignation()
        //Accesseur : Méthode qui permet de récupérer la valeur d'une propriété
        {
            return (this.designation);
        }

        public int getReference()
        //Accesseur
        {
            return (this.reference);
        }

    }
}
