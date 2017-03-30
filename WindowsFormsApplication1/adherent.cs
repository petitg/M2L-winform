using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class adherent
    {
        private int id;
        private string nom;
        private string prenom;
        private char sexe;
        private string dateNaissance;
        private string rueAdresse; 
        private string cp;
        private string ville;
        private int cotisation;

        public adherent(int myid, string mynom, string myprenom, char mysexe, string mydateNaissance, string myrueAdresse, string mycp, string myville, int mycotisation)
        {
            id = myid;
            nom = mynom;
            prenom = myprenom;
            sexe = mysexe;
            dateNaissance = mydateNaissance;
            rueAdresse = myrueAdresse;
            cp = mycp;
            ville = myville;
            cotisation = mycotisation;
        }
        public adherent(string mynom, string myprenom, char mysexe, string mydateNaissance, string myrueAdresse, string mycp, string myville, int mycotisation)
        {
            id = 0;
            nom = mynom;
            prenom = myprenom;
            sexe = mysexe;
            dateNaissance = mydateNaissance;
            rueAdresse = myrueAdresse;
            cp = mycp;
            ville = myville;
            cotisation = mycotisation;
        }

        public int getId() {return id;}
        public string getNom() { return nom;}
        public string getPrenom() { return prenom;}
        public char getSexe() { return sexe;}
        public string getDateNaissance() { return dateNaissance; }
        public string getRueAdresse() { return rueAdresse;}
        public string getCp() { return cp;}
        public string getVille() { return ville;}
        public int getCotisation() { return cotisation;}

        public void setId(int leNouveau) { id = leNouveau;}
        public void setNom(string leNouveau) { nom = leNouveau;}
        public void setPrenom(string leNouveau) { prenom = leNouveau;}
        public void setAdresse(string nouveauRue, string nouveauCp, string nouveauVille ) { rueAdresse = nouveauRue; cp = nouveauCp; ville = nouveauVille;}
        public void setCotisation(int leNouveau) { cotisation = leNouveau;}
             



    }
}
