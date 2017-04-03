using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{

    
    public enum Metiers
    {    
            ANA,
            CDP,
            DEV,
            DES,
            TES
    }
   public class Personne
    {
        #region Propriétés
        public string CodePersonne { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Metiers Metier { get; set; }



        #endregion


        #region Constructeur

        public Personne(string codePersonne,string nom,string prenom,Metiers metier)
        {
            CodePersonne = codePersonne;
            Nom = nom;
            Prenom = prenom;
            Metier = metier;

        }

        #endregion


    }
}
