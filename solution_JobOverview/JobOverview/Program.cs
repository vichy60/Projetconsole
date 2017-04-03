using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            Projet proj = DAL.ChargerDonnées(@"D:\ycappelle\projetconsole\Projetconsole\solution_JobOverview\DataProject.txt");

            Console.ReadKey();
            //string reponse="O";
            //string code;
            //string libelle;
            //var dicoActAnex = new Dictionary<string, Activ_Annexes>();

            //while (reponse == "O")
            //{
            //    Console.WriteLine("saisir le code de l'activité sur 3 caractéres en Majuscule");
            //    code = Console.ReadLine();
              
            //    Console.WriteLine("saisir le Libellé de l'activité ");
            //    libelle = Console.ReadLine();
            //    Activ_Annexes actAnx1 = new Activ_Annexes(code, libelle);
            //    dicoActAnex.Add(actAnx1.CodeActivite, actAnx1);
            //    Console.WriteLine("voulez vous saisir une autre activité? O/N");
            //    reponse = Console.ReadLine();
            //}


        }
    }
}
