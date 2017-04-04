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


            // Changement des données du fichier DataProject.txt dans une instance de la classe Projet (crée dans la méthode ChargerDonnées() de la classe DAL).
            Projet proj = DAL.ChargerDonnées(@"D:\ycappelle\projetconsole\Projetconsole\solution_JobOverview\DataProject.txt");


            // Saisie d'un dictionnaire avec les Code activités anneexes sur 3 caractères et leur Libellé.
            // ajout d'un controle d'existance du code activités dans le dictionnaire.
            string reponse = "O";
            string code = string.Empty;
            string libelle;
            var dicoActAnex = new Dictionary<string, string>();

            while (reponse == "O")
            {
                do
                {
                    Console.WriteLine("saisir le code de l'activité sur 3 caractéres en Majuscule");
                    code = Console.ReadLine().ToUpper();
                }
                while (dicoActAnex.ContainsKey(code) | code.Length != 3);

                Console.WriteLine("saisir le Libellé de l'activité ");
                libelle = Console.ReadLine();
                // Activ_Annexes actAnx1 = new Activ_Annexes(code, libelle);
                dicoActAnex.Add(code, libelle);
                Console.WriteLine("voulez vous saisir une autre activité? O/N");
                reponse = Console.ReadLine().ToUpper();
            }
            Console.Clear();
            Console.WriteLine("les activités annexes déjà saisie sont les suivantes --> \n");
            foreach (var r in dicoActAnex)
            {
                Console.WriteLine("code:   {0} avec le libelle {1}", r.Key, r.Value);

            }
            Console.ReadKey();



            ////// SUIVI DE PRODUCTION ////////////////
            //affichage du retour de la méthode: DureeTravailRealiseEtRestantPersonne() qui nous donne la durée
            //réalisée et restante d'une personne sur une version

            Results result = new Results(proj);

            Console.WriteLine(result.DureeTravailRealiseEtRestantPersonne("2.00"));

            Console.ReadKey();

            Console.WriteLine(result.EcartDureeRealisePrevu());
            Console.ReadKey();

        }
    }
}
