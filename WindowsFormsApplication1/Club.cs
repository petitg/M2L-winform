using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class club
    {
        private string nom;
        private string site;
        private string adresse;
        private string telephone;
        private string email;
        private string type;
        private int id;

        public club(string mynom, string mysite, string myadresse, string mytelephone, string myemail, string mytype, int myid)
        {
            nom = mynom;
            site = mysite;
            adresse = myadresse;
            telephone = mytelephone;
            email = myemail;
            type = mytype;
            id = myid;
        }

        public string getNom() { return nom; }
        public string getSite() { return site; }
        public string getAdresse() { return adresse; }
        public string getTelephone() { return telephone; }
        public string getEmail() { return email; }
        public string getType() { return type; }
        public int getId() { return id; }

        public void setNom(string leNouveau) { nom = leNouveau; }
        public void setSite(string LeNouveau) { site = LeNouveau; }
        public void setAdresse(string leNouveau) { adresse = leNouveau; }
        public void setTelephone(string leNouveau) { telephone = leNouveau; }
        public void setEmail(string leNouveau) { email = leNouveau; }
        public void setType(string leNouveau) { type = leNouveau; }
        public void setId(int leNouveau) { id = leNouveau; }
    }
}
