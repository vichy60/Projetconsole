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


            bool c = true;
            string reponse = "O";
            string code = string.Empty;
            string libelle;
            var dicoActAnex = new Dictionary<string, string>();

            while (reponse == "O")
            {
                do
                {
                    Console.WriteLine("saisir le code de l'activité sur 3 caractéres en Majuscule");
                    code = Console.ReadLine();
                }
                while (dicoActAnex.ContainsKey(code));

                Console.WriteLine("saisir le Libellé de l'activité ");
                libelle = Console.ReadLine();
                // Activ_Annexes actAnx1 = new Activ_Annexes(code, libelle);
                dicoActAnex.Add(code, libelle);
                Console.WriteLine("voulez vous saisir une autre activité? O/N");
                reponse = Console.ReadLine();
            }


        }
    }
}
