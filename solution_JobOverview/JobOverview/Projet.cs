using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public class Projet
    {
        #region Champs privés
        private List<TachesProduc> _tachesProd;
        #endregion

        #region Propriétés
        #endregion

        #region Constructeurs
        public Projet()
        {
            _tachesProd = new List<TachesProduc>();
        }

        #endregion

        #region Méthodes privés

        #endregion

        #region Méthodes publiques
        public void AddTache(TachesProduc tache)
        {
            _tachesProd.Add(tache);
        }
        #endregion

    }
}
