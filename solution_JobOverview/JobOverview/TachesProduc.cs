﻿using System;
using System.Collections.Generic;
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
    public class TachesProduc 
    {
        #region Propriété
        public int NumTache { get; }
        public string Version { get; }
        public Personne Personne { get; }
        public Activites Activité { get; }

        public string LibTache { get; }
        public DateTime DateDeb { get; }
        public int Prevu { get; set; }
        public int Realise { get; }
        public int Restant { get; }
        #endregion
        #region Constructeur
        public TachesProduc(int numTache, string version, Personne personne, Activites activité,
                string libTache, DateTime dateDeb, int prevu, int realise, int restant)
        {
            NumTache = numTache;
            Version = version;
            Personne = personne;
            Activité = activité;
            LibTache = libTache;
            DateDeb = dateDeb;
            Prevu = prevu;
            Realise = realise;
            Restant = restant;
        }

        public TachesProduc()
        {

        }

        #endregion

        #region Methode


        #endregion
    }
}
