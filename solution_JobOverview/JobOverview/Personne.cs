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

        public string CodePersonne { get;}
        public string Nom { get;  }
        public string Prenom { get; }
        public Metiers Metier { get;  }
        
        #endregion


        #region Constructeur

        public Personne(string codePersonne, string nom, string prenom, Metiers metier)
        {
            CodePersonne = codePersonne;
            Nom = nom;
            Prenom = prenom;
            Metier = metier;

        }

        #endregion


    }
}
