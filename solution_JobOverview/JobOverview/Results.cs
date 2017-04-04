using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public class Results
    {
        #region propriétés
        public Projet proj { get; }
        #endregion

        #region constructeurs
        public Results(Projet projet)
        {
            proj = projet;
        }

        #endregion

        #region Methodes


        /// <summary>
        /// methode pour le calcul de la duree de travail realise et restant pour une personne sur une version passée en paramètre.
        /// </summary>
        /// <param name="vers"></param>
        /// <returns></returns>

        public string DureeTravailRealiseEtRestantPersonne(string vers)
        {
            string resString = "Sur la version" + vers + ":\n";

            var tachesVers = proj.TachesProduc.Where(v => v.Version == vers);

            var pers = tachesVers.Select(p => p.Personne).Distinct();

            foreach (var perso in pers)
            {
                var res = tachesVers.Where(p => p.Personne == perso).Sum(d => d.Realise);
                var res1 = tachesVers.Where(p => p.Personne == perso).Sum(d => d.Restant);


                resString += string.Format("{0}{1} a réalisé {2} jours de travail, et il lui reste {3} jours de planifiés.\n", perso.Prenom, perso.Nom, res, res1);
            }

            return resString;
        }


        /// <summary>
        /// methode pour le calcul de l'écart en nombre de jours et pourcentage entre durée prévue et durée réalisée.
        /// </summary>
        /// <returns></returns>
        public string EcartDureeRealisePrevu()
        {
            string resString = "Le nombre de jour de retard ou d'avance sur le projet \n";
            var versions = proj.TachesProduc.Select(v => v.Version).Distinct();

            foreach (var ver in versions)
            {
                var somPrevu = proj.TachesProduc.Where(v => v.Version == ver).Sum(d => d.Prevu);
                var somReal = proj.TachesProduc.Where(v => v.Version == ver).Sum(d => d.Realise);
                int ecart = somPrevu - somReal;
                double pourcent = ((double)ecart / (double)somPrevu) * 100;

                resString += string.Format("version{0} --> écart {1}  soit en pourcentage: {2:F2} % \n", ver, ecart, pourcent);
            }
            return resString;
        }

        // Methode pour le calcul de la Duree Totale Réalisée par activité sur chaque version

        public string DureeTotalRealiseActiviteVesrion()
        {
            return "";              //TODO   faire dernière méthode de suivi si il reste du temps!!
        }



        #endregion


    }
}
