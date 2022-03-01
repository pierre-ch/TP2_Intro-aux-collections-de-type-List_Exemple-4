using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Type_List_Exemple4
{
    class Joueur
    {
        private string numLicenceJoueur;
        private string nomJoueur;
        private string prenomJoueur;
        private DateTime dateNaissance;

        public Joueur(string leNumLicence, string leNom, string lePrenom, DateTime laDateNaissance)
        {
            this.numLicenceJoueur = leNumLicence;
            this.nomJoueur = leNom;
            this.prenomJoueur = lePrenom;
            this.dateNaissance = laDateNaissance;
        }   

        public string getNumLicence()
        {
            return this.numLicenceJoueur;
        }

        public string getNom()
        {
            return this.nomJoueur;
        }

        public string getPrenom()
        {
            return this.prenomJoueur;
        }

        public void setNom(string leNom)
        {
            this.nomJoueur = leNom;
        }

        public void setPrenom (string lePrenom)
        {
            this.nomJoueur = lePrenom;
        }

        public void setDateNaissance(DateTime laDateNaissance)
        {
            this.dateNaissance = laDateNaissance;
        }

        public string afficheInformations()
        {
            string vretour = ("");
            vretour = "Numéro de licence : " + this.numLicenceJoueur + "\n";
            vretour += "Nom du joueur : " + this.nomJoueur + "\n";
            vretour += "Prénom du joueur : " + this.prenomJoueur + "\n";
            vretour += "DDN du joueur : " + this.dateNaissance + "\n";
            return vretour;
        }

    }
}
