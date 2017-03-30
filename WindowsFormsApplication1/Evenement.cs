using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class evenement
    {
        private int id;
        private string nom;
        private string type;
        private string dateDebut;
        private string dateFin;
        private string adresse;
        private int idClub;

        public evenement(int myid, string mynom, string mytype, string mydateDebut, string mydateFin, string myadresse, int myidclub)
        {
            id = myid;
            nom = mynom;
            type = mytype;
            dateDebut = mydateDebut;
            dateFin = mydateFin;
            adresse = myadresse;
            idClub = myidclub;
        }

        public int getId() { return id; }
        public string getNom() { return nom; }
        public string getType() { return type; }
        public string getdateDebut() { return dateDebut; }
        public string getdateFin() { return dateFin; }
        public string getadresse() { return adresse; }
        public int getidclub() { return idClub; }

        public void setId(int leNouveau) { id = leNouveau; }
        public void setNom(string leNouveau) { nom = leNouveau; }
        public void setDateDebut(string leNouveau) { dateDebut = leNouveau; }
        public void setDateFin(string leNouveau) { dateFin = leNouveau; }
        public void setAdresse(string leNouveau) { adresse = leNouveau; }
        public void setIdclub(int leNouveau) { idClub = leNouveau; }
        
    }
}
