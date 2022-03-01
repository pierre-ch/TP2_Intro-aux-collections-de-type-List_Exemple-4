using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Type_List_Exemple4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d0 = new DateTime(1972, 06, 23);
            List<Joueur> lesJoueurs = new List<Joueur>();
            lesJoueurs.Add(new Joueur("12345", "Zidane", "Zinédine", d0));

            Console.WriteLine(lesJoueurs[0].afficheInformations());

            Console.ReadKey();
        }
    }
}
