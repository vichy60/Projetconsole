using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{

    public enum Activites
    {
        DBE,
        ARF,
        ANF,       
        DES,
        INF,
        ART,
        ANT,
        DEV,
        RPT,
        TES,
        GDP
    }
    public static class DAL
    {
        #region Champs privés

        #endregion

        #region Propriétés
        public static Dictionary<string,Personne> DicoPersonnes { get; }
        public static Dictionary<string, Activites> DicoActivite { get; }
        #endregion

        #region Constructeurs

        static DAL()
        {
            DicoPersonnes = new Dictionary<string, Personne>();
            DicoPersonnes.Add("GL", new Personne("GL","LECLERCQ","Genevieve",Metiers.ANA));
            DicoPersonnes.Add("AF", new Personne("AF", "FERRAND", "Angele", Metiers.ANA));
            DicoPersonnes.Add("BN", new Personne("BN", "NORMAND", "Balthazar", Metiers.CDP));
            DicoPersonnes.Add("RF", new Personne("RF", "FISHER", "Raymond", Metiers.DEV));
            DicoPersonnes.Add("LB", new Personne("LB", "BUTLER", "Lucien", Metiers.DEV));
            DicoPersonnes.Add("RB", new Personne("RB", "BEAUMONT", "Roseline", Metiers.DEV));
            DicoPersonnes.Add("MW", new Personne("MW", "WEBER", "Marguerite", Metiers.DES));
            DicoPersonnes.Add("HK", new Personne("HK","KLEIN", "Hilaire", Metiers.TES));
            DicoPersonnes.Add("NP", new Personne("NP", "PALMER", "Nino", Metiers.TES));

            DicoActivite = new Dictionary<string, Activites>();
            DicoActivite.Add("DBE", Activites.DBE);
            DicoActivite.Add("ARF", Activites.ARF);
            DicoActivite.Add("ANF", Activites.ANF);
            DicoActivite.Add("DES", Activites.DES);
            DicoActivite.Add("INF", Activites.INF);
            DicoActivite.Add("ART", Activites.ART);
            DicoActivite.Add("ANT", Activites.ANT);
            DicoActivite.Add("DEV", Activites.DEV);
            DicoActivite.Add("RPT", Activites.RPT);
            DicoActivite.Add("TES", Activites.TES);
            DicoActivite.Add("GDP", Activites.GDP);

        }

        #endregion

        #region Méthodes privés

        #endregion

        #region Méthodes publiques
        public static Projet ChargerDonnées(string path)
        {
            Projet projet = new Projet();
            // TODO : implémenter DAL::ChargerDonnées()
            string[] data = File.ReadAllLines(path);
            string[] ligne;
            for(int i = 1; i < data.Length; i++)
            {
                ligne = data[i].Split('\t');
                projet.AddTache(new TachesProduc(int.Parse(ligne[0]), ligne[1], DicoPersonnes[ligne[2]], DicoActivite[ligne[3]],ligne[4],
                        DateTime.Parse(ligne[5]),int.Parse(ligne[6]), int.Parse(ligne[7]), int.Parse(ligne[8])));
            }

            return projet;
        }
        #endregion
    }
}
